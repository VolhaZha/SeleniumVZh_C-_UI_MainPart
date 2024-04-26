using OpenQA.Selenium;
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

    }
}
