namespace FluentPro.FluentPS.Psi.Network.Types
{
    using Exceptions.Faults;
    using Model.Enums;
    using Bindings;
    using ChannelFactories;
    using System;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Web;
    using System.ServiceModel.Security;

    public class PsiService<TChannel>
    {
        private const string PsiServiceRelativeUrl = "_vti_bin/PSI/ProjectServer.svc";

        private readonly System.Type _channelType;
        private readonly Uri _pwaUri;
        private Binding _binding;
        private EndpointAddress _address;
        private ChannelFactory<TChannel> _channelFactory;
        private AuthType _authType;

        public PsiService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
            _channelType = typeof(TChannel);
            _authType = AuthType.Windows;
        }

        public ChannelFactory<TChannel> ChannelFactory
        {
            get
            {
                if (_channelFactory == null)
                {
                    _binding = new HttpPsiWcfBinding();
                    if (_pwaUri.Scheme == Uri.UriSchemeHttps)
                    {
                        _binding = new HttpsPsiWcfBinding();
                    }

                    _address = new EndpointAddress(new Uri(_pwaUri, PsiServiceRelativeUrl));
                    _channelFactory = new PsiChannelFactory<TChannel>(_binding, _address);
                }

                return _channelFactory;
            }
        }

        public TResult Invoke<TResult>(Func<TChannel, TResult> func)
        {
            Trace.TraceInformation("Open channel for {0}:{1}", _pwaUri, _channelType.Name);
            var channel = (IClientChannel)ChannelFactory.CreateChannel();
            bool success = false;
            try
            {
                Trace.TraceInformation("Invoke action on {0}:{1}", _pwaUri, _channelType.Name);

                TResult result;
                using (var scope = new OperationContextScope(channel))
                {
                    Trace.TraceInformation("Current AuthType = {0}", _authType);
                    if (_authType == AuthType.Windows)
                    {
                        WebOperationContext.Current.OutgoingRequest.Headers.Remove("X-FORMS_BASED_AUTH_ACCEPTED");
                        WebOperationContext.Current.OutgoingRequest.Headers.Add("X-FORMS_BASED_AUTH_ACCEPTED", "f");
                    }

                    Trace.Indent();
                    result = func((TChannel)channel);
                    Trace.Unindent();
                }

                Trace.TraceInformation("Close channel for {0}:{1}", _pwaUri, _channelType.Name);
                channel.Close();
                success = true;
                return result;
            }
            catch (FaultException<ServerExecutionFault> fault)
            {
                Trace.Unindent();
                Trace.TraceError("Failed to invoke action on channel for {0}:{1}. Message: {2}", _pwaUri, _channelType.Name, fault.Detail.Message);
                throw;
            }
            catch (MessageSecurityException ex)
            {
                // TODO: Add handling of invalid dates
                // https://social.msdn.microsoft.com/Forums/en-US/85a42068-050e-4713-a4a4-1315882f0130/generaldatenotvalid-error-when-updating-resource-hire-date?forum=project2010custprog

                Trace.Unindent();
                Trace.TraceError("Failed to invoke action on channel for {0}:{1}. Message: {2}", _pwaUri, _channelType.Name, ex.Message);
                Trace.TraceError("Check your Project WebApp Url, it can be not valid: {0}.", _pwaUri);
                throw;
            }
            catch (Exception ex)
            {
                Trace.Unindent();
                Trace.TraceError("Failed to invoke action on channel for {0}:{1}. Message: {2}", _pwaUri, _channelType.Name, ex.Message);
                throw;
            }
            finally
            {
                if (!success)
                {
                    Trace.TraceInformation("Abort channel for {0}:{1}", _pwaUri, _channelType.Name);
                    channel.Abort();
                }
            }

            //TODO: Add more catch and exception handling
        }

        public void Invoke(Action<TChannel> action)
        {
            Invoke(channel =>
            {
                action(channel);
                return false;
            });
        }
    }
}
