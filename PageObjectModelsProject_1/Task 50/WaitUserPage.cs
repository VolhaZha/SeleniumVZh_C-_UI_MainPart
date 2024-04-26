using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50
{
    public class WaitUserPage : BasePage
    {
        public WaitUserPage(IWebDriver driver) : base(driver)
        {

        }
        public void WaitForUser()
        {
            IWebElement getNewUserButton = FindElementBy(WaitUserParams.LINK_TO_GET_NEW_USER);
            getNewUserButton.Click();

            System.Threading.Thread.Sleep(5000);
        }

        public bool CheckResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _driver.FindElement(WaitUserParams.EXPLICIT_WAIT_SELECTOR);
                    return elementToBeDisplayed.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return result;
        }

    }
}
