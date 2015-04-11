namespace FluentPro.FluentPS.Psi.Network.Bindings
{
    using System.Linq;
    using System.Net;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using System.ServiceModel;

    public class HttpsPsiWcfBinding : PsiWcfBinding
    {
        public HttpsPsiWcfBinding()
        {
            Security.Mode = BasicHttpSecurityMode.Transport;

            if (ServicePointManager.ServerCertificateValidationCallback == null)
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            }

            if (!ServicePointManager.ServerCertificateValidationCallback.GetInvocationList().Contains(new RemoteCertificateValidationCallback(CustomCertificateValidation)))
            {
                ServicePointManager.ServerCertificateValidationCallback += CustomCertificateValidation;
            }
        }

        private static bool CustomCertificateValidation(object sender, X509Certificate cert, X509Chain chain, SslPolicyErrors error)
        {
            return true;
        }
    }
}
