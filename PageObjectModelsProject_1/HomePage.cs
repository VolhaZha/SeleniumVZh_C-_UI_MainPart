using OpenQA.Selenium;

namespace SeleniumVZhTestProject_1
{
    public class HomePage : BasePage
    {
        private const int WAIT_TIME_10 = 10;
        private By LOGIN_BUTTON = By.ClassName ("resplash-btn_primary");
        IWebElement _loginButton;
        public HomePage(IWebDriver driver) : base(driver)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_TIME_10);
            _loginButton = FindElementBy(LOGIN_BUTTON);
        }

        public void GoToLoginWindow()
        {
            _loginButton?.Click();
        }

        public bool LogOutSuccess()
        {
            try
            {
                var loginButton = FindElementBy(LOGIN_BUTTON);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
