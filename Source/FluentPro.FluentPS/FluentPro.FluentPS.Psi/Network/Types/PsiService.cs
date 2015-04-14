using FluentPro.FluentPS.Contracts.Constants;
using FluentPro.FluentPS.Network.Types;
using FluentPro.FluentPS.Psi.Network.Bindings;
using FluentPro.FluentPS.Psi.Network.ChannelFactories;
using System;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Network.Types
{
    public class PsiService<T> where T : IClientChannel
    {
        private readonly Uri _pwaUri;
        private PsiWcfBinding _binding;
        private EndpointAddress _address;
        private ChannelFactory<T> _channelFactory;

        public PsiService(Uri pwaUri)
        {
            _pwaUri = pwaUri;
        }

        public TResult Invoke<TResult>(Func<T, TResult> func)
        {
            var channel = (IClientChannel)ChannelFactory.CreateChannel();
            bool success = false;
            try
            {
                var result = func((T)channel);
                channel.Close();
                success = true;
                return result;
            }
            //TODO: Add http://stackoverflow.com/questions/576185/logging-best-practices somewhere to readme
            //catch (FaultException<ServerExecutionFault> fault)
            //{ //TODO: Add more exception handlers
            //}
            finally
            {
                if (!success)
                {
                    channel.Abort();
                }
            }
        }

        public QueueJob Invoke(Action<T, QueueJob> action)
        {
            var job = new QueueJob(_pwaUri);
            Invoke(channel => action(channel, job));
            return job;
        }

        public void Invoke(Action<T> action)
        {
            Invoke(channel =>
            {
                action(channel);
                return false;
            });
        }

        private ChannelFactory<T> ChannelFactory
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

                    _address = new EndpointAddress(new Uri(_pwaUri, Urls.PsiServiceRelativeUrl));
                    _channelFactory = new PsiChannelFactory<T>(_binding, _address);
                }

                return _channelFactory;
            }
        }
    }
}
