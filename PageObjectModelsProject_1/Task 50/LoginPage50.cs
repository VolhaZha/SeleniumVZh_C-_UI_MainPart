using OpenQA.Selenium;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50
{
    public class LoginPage50 : BasePage
    {
        IWebElement _nameField;
        IWebElement _passField;
        IWebElement _loginButton;
        IWebElement _loggedLogo;

        public LoginPage50(IWebDriver driver) : base(driver)
        {
            _nameField = FindElementBy(LoginParams.NAME_FIELD);
            _passField = FindElementBy(LoginParams.PASS_FIELD);
            _loginButton = FindElementBy(LoginParams.LOGIN_BUTTON);
        }

        public void EnterCreds(string name, string password)
        {
            _nameField?.SendKeys(name);
            _passField?.SendKeys(password);
            _loginButton?.Click();
        }

        public bool LogInSuccess()
        {
            try
            {
                _loggedLogo = FindElementBy(LoginParams.LOGGED_LOGO);
                var writeButton = FindElementBy(LoginParams.LOGGED_LOGO);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
