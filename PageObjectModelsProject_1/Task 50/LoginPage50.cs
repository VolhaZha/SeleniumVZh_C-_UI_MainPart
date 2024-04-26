using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50
{
    public class LoginPage50 : BasePage
    {
        IWebElement _nameField;
        IWebElement _passField;
        IWebElement _loginButton;

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

        public bool CheckResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _driver.FindElement(By.ClassName("app_logo"));
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
