using OpenQA.Selenium;

namespace SeleniumVZhTestProject_1
{
    public class LoginPage : BasePage
    {
        private const int WAIT_TIME_10 = 10;
        private By IFRAME = By.XPath("//iframe[contains(@class, 'ag-popup__frame__layout__iframe')]");
        private By NAME_FIELD = By.XPath ("//input[@name='username']");
        private By ENTER_PASS_BUTTON = By.ClassName ("submit-button-wrap");
        private By PASS_FIELD = By.XPath ("//input[@name='password']");
        private By ENTER_SIGN_IN_BUTTON = By.ClassName ("submit-button-wrap");
        private By WRITE_BUTTON = By.ClassName ("compose-button__txt");

        IWebElement _iframeElement;
        IWebElement _nameField;
        IWebElement _enterPassButton;
        IWebElement _passField;
        IWebElement _enterSignInButton;

        public LoginPage(IWebDriver driver) : base(driver)
        {
            _iframeElement = FindElementBy(IFRAME);
            _driver.SwitchTo().Frame(_iframeElement);

            _nameField = FindElementBy(NAME_FIELD);
            _enterPassButton = FindElementBy(ENTER_PASS_BUTTON);
            _passField = FindElementBy(PASS_FIELD);
            _enterSignInButton = FindElementBy(ENTER_SIGN_IN_BUTTON);
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
                var writeButton = FindElementBy(WRITE_BUTTON);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
