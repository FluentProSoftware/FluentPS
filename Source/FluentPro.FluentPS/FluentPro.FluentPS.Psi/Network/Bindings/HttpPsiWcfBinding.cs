namespace FluentPro.FluentPS.Psi.Network.Bindings
{
    using System.ServiceModel;

    public class HttpPsiWcfBinding : PsiWcfBinding
    {
        public HttpPsiWcfBinding()
        {
            Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
        }
    }
}
