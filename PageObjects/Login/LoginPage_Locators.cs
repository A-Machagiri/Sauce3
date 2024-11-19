// LoginPage_Locators.cs
using OpenQA.Selenium;

namespace AutomationFramework.PageObjects.Login
{
    public partial class LoginPage
    {
        public By UsernameField = By.Id("user-name");
        public By PasswordField = By.Id("password");
        public By LoginButton = By.Id("login-button");
        public By ErrorMessage = By.CssSelector(".error-message-container");
        public By ProductsPageTitle = By.CssSelector(".title");
    }
}