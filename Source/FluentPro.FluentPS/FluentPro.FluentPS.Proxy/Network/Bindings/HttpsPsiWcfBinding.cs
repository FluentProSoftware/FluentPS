namespace FluentPro.FluentPS.Proxy.Network.Bindings
{
    using System.ServiceModel;

    public class HttpsPsiWcfBinding : PsiWcfBinding
    {
        public HttpsPsiWcfBinding()
        {
            Security.Mode = BasicHttpSecurityMode.Transport;
        }
    }
}
