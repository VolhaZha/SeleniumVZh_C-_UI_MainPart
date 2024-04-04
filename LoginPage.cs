using OpenQA.Selenium;

namespace SeleniumVZhTestProject_1
{
    public class LoginPage : BasePage
    {
        private const int WAIT_TIME_10 = 10;
        private const string IFRAME = "//iframe[contains(@class, 'ag-popup__frame__layout__iframe')]";
        private const string NAME_FIELD = "//input[@name='username']";
        private const string ENTER_PASS_BUTTON = "submit-button-wrap";
        private const string PASS_FIELD = "//input[@name='password']";
        private const string ENTER_SIGN_IN_BUTTON = "submit-button-wrap";
        private const string WRITE_BUTTON = "compose-button__txt";

        IWebElement _iframeElement;
        IWebElement _nameField;
        IWebElement _enterPassButton;
        IWebElement _passField;
        IWebElement _enterSignInButton;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _iframeElement = FindElementByXPath(IFRAME);
            _driver.SwitchTo().Frame(_iframeElement);

            _nameField = FindElementByXPath(NAME_FIELD);
            _enterPassButton = FindElementByClassName(ENTER_PASS_BUTTON);
            _passField = FindElementByXPath(PASS_FIELD);
            _enterSignInButton = FindElementByClassName(ENTER_SIGN_IN_BUTTON);
        }

        public void EnterCreds(string name, string password)
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(WAIT_TIME_10);

            _nameField?.SendKeys(name);

            _enterPassButton?.Click();

            _passField?.SendKeys(password);

            _enterSignInButton?.Click();
            _driver.SwitchTo().DefaultContent();
        }

        public bool LogInSuccess()
        {
            try
            {
                var writeButton = FindElementByClassName(WRITE_BUTTON);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
