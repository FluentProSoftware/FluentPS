namespace FluentPro.FluentPS.Proxy.Network.Bindings
{
    using System;
    using System.ServiceModel;

    public class PsiWcfBinding : BasicHttpBinding
    {
        const int MaxSize = 500000000;

        public PsiWcfBinding()
        {
            Name = "basicHttpConf";
            SendTimeout = TimeSpan.MaxValue;
            MaxReceivedMessageSize = MaxSize;
            ReaderQuotas.MaxNameTableCharCount = MaxSize;
            MessageEncoding = WSMessageEncoding.Text;
            Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
        }
    }
}
