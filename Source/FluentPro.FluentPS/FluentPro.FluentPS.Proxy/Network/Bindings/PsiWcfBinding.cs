namespace FluentPro.FluentPS.Psi.Network.Bindings
{
    using System;
    using System.ServiceModel;

    public class PsiWcfBinding : BasicHttpBinding
    {
        public PsiWcfBinding()
        {
            Name = "basicHttpConf";
            SendTimeout = TimeSpan.MaxValue;
            MaxReceivedMessageSize = int.MaxValue;
            MessageEncoding = WSMessageEncoding.Text;
            Security.Transport.ClientCredentialType = HttpClientCredentialType.Ntlm;
            MaxBufferSize = int.MaxValue;
            MaxBufferPoolSize = int.MaxValue;
            ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
            ReaderQuotas.MaxArrayLength = int.MaxValue;
            ReaderQuotas.MaxNameTableCharCount = int.MaxValue;
            ReaderQuotas.MaxDepth = int.MaxValue;
            ReaderQuotas.MaxStringContentLength = int.MaxValue;
        }
    }
}
