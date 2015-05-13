namespace FluentPro.FluentPS.Psi.Network.Types
{
    using FluentPro.FluentPS.Psi.Exceptions.Faults;
    using FluentPro.FluentPS.Psi.Network.Bindings;
    using FluentPro.FluentPS.Psi.Network.ChannelFactories;
    using System;
    using System.Diagnostics;
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public class PsiService<TChannel>
    {
        private const string PsiServiceRelativeUrl = "_vti_bin/PSI/ProjectServer.svc";

        private readonly Type _channelType;
        private readonly Uri _pwaUri;
        private Binding _binding;
        private EndpointAddress _address;
        private ChannelFactory<TChannel> _channelFactory;

        public PsiService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
            _channelType = typeof(TChannel);
        }

        public TResult Invoke<TResult>(Func<TChannel, TResult> func)
        {
            Trace.TraceInformation("Open channel for {0}:{1}", _pwaUri, _channelType.Name);
            var channel = (IClientChannel)ChannelFactory.CreateChannel();
            bool success = false;
            try
            {
                Trace.TraceInformation("Invoke action on {0}:{1}", _pwaUri, _channelType.Name);

                Trace.Indent();
                var result = func((TChannel)channel);
                Trace.Unindent();

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
        }

        public void Invoke(Action<TChannel> action)
        {
            Invoke(channel =>
            {
                action(channel);
                return false;
            });
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
    }
}
