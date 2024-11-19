// LoginPage_Actions.cs
using AutomationFramework.Utilities;

namespace AutomationFramework.PageObjects.Login
{
    public partial class LoginPage
    {
        private WebUtilities webUtilities;

        public LoginPage(WebUtilities utilities)
        {
            this.webUtilities = utilities;
        }

        public void EnterCredentials(string username, string password)
        {
            webUtilities.SendKeys(UsernameField, username);
            webUtilities.SendKeys(PasswordField, password);
        }

        public void ClickLoginButton()
        {
            webUtilities.Click(LoginButton);
        }

        public string GetErrorMessage()
        {
            return webUtilities.FindElement(ErrorMessage).Text;
        }

        public bool IsOnProductsPage()
        {
            return webUtilities.FindElement(ProductsPageTitle).Displayed;
        }
    }
}