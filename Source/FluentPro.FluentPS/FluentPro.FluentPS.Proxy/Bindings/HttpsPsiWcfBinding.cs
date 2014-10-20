namespace FluentPro.FluentPS.Proxy.Bindings
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
