using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;

namespace SeleniumVZhTestProject_1
{
    public class BasePage
    {
        protected IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement FindElementByClassName(string className)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            try
            {
                return wait.Until(driver => driver.FindElement(By.ClassName(className)));
            }
            catch (NoSuchElementException ex)
            {
                throw;
            }
        }

        public IWebElement FindElementByXPath(string xPath)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            try
            {
                return wait.Until(driver => driver.FindElement(By.XPath(xPath)));
            }
            catch (NoSuchElementException ex)
            {
                throw;
            }
        }

        public IWebElement FindElementByCSS(string cssSelector)
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));
            try
            {
                return wait.Until(driver => driver.FindElement(By.CssSelector(cssSelector)));
            }
            catch (NoSuchElementException ex)
            {
                throw;
            }
        }
    }
}
