using System.Configuration;
using Microsoft.Owin;

namespace WebApplication1
{
    public class ConfigService
    {
        public class Account
        {
            private static string AuthenticatorBasePass
            {
                get { return ConfigurationManager.AppSettings.Get("authenticator-base-url"); }
            }

            public static readonly string LoginUrl = AuthenticatorBasePass + "Account/Login";
            public static readonly string RegisterUrl = AuthenticatorBasePass + "Account/Register";
            public static readonly string ManageUrl = AuthenticatorBasePass + "Manage";
            public static readonly string LogOffUrl = AuthenticatorBasePass + "Account/LogOff";

            public static string GetLoginWithReturnUrl(string returnUrl)
            {
                return LoginUrl + new QueryString("returnUrl", returnUrl);
            }
        }
    }
}
