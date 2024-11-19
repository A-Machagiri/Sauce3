// LoginSteps.cs
using AutomationFramework.PageObjects.Login;
using AutomationFramework.Utilities;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace AutomationFramework.Test_Layer.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private LoginPage loginPage;
        private WebUtilities webUtilities;

        public LoginSteps(ScenarioContext scenarioContext)
        {
            webUtilities = (WebUtilities)scenarioContext["WebUtilities"];
            loginPage = new LoginPage(webUtilities);
        }

        [Given("I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            webUtilities.NavigateToUrl("https://www.saucedemo.com/");
        }

        [When("I enter valid username '(.*)' and valid password '(.*)'")]
        public void WhenIEnterValidUsernameAndValidPassword(string username, string password)
        {
            loginPage.EnterCredentials(username, password);
        }

        [When("I click on the login button")]
        public void WhenIClickOnTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then("I should be redirected to the products page")]
        public void ThenIShouldBeRedirectedToTheProductsPage()
        {
            Assert.IsTrue(loginPage.IsOnProductsPage());
        }

        [Then("I should see an error message indicating (.*)")]
        public void ThenIShouldSeeAnErrorMessageIndicating(string message)
        {
            Assert.AreEqual(message, loginPage.GetErrorMessage());
        }
    }
}