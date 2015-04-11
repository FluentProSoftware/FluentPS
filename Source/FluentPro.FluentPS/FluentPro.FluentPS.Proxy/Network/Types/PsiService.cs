using FluentPro.FluentPS.Psi.Exceptions.Faults;
using System;
using System.Diagnostics;
using System.ServiceModel;

namespace FluentPro.FluentPS.Psi.Network.Types
{
    public class PsiService<T>
    {
        private readonly ChannelFactory<T> _channelFactory;

        public PsiService(ChannelFactory<T> channelFactory)
        {
            _channelFactory = channelFactory;
        }

        public TResult Invoke<TResult>(Func<T, TResult> func)
        {
            var channel = (IClientChannel)_channelFactory.CreateChannel();
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

        public void Invoke(Action<T> action)
        {
            Invoke(channel => action(channel));
        }
    }
}
