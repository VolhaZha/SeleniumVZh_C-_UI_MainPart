using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task70_Pages;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task120_Pages
{
    public class SL_LogInPage : BasePage
    {
        IWebElement _nameField;
        IWebElement _passField;
        IWebElement _loginButton;

        public SL_LogInPage(IWebDriver driver) : base(driver)
        {
            _nameField = FindElementBy(LogInOutParams.NAME_FIELD);
            _passField = FindElementBy(LogInOutParams.PASS_FIELD);
            _loginButton = FindElementBy(LogInOutParams.LOGIN_BUTTON);
        }

        public void EnterCreds(string name, string password)
        {
            _nameField?.SendKeys(name);
            _passField?.SendKeys(password);
            _loginButton?.Click();
        }

        public bool CheckLogoutResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _loginButton;
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
