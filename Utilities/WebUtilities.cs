using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace AutomationFramework.Utilities
{
    public class WebUtilities
    {
        private IWebDriver driver;

        public IWebDriver InitializeDriver(string browserType)
        {
            switch (browserType.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    break;
                case "firefox":
                    driver = new FirefoxDriver();
                    break;
                case "edge":
                    driver = new EdgeDriver();
                    break;
                default:
                    throw new ArgumentException("Browser not supported");
            }
            return driver;
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public void SendKeys(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }

        public void Quit()
        {
            driver.Quit();
        }
    }
}