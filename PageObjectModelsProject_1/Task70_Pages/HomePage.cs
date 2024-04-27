using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task70_Pages
{
    public class HomePage : BasePage
    {
        IWebElement _loggedLogo;
        IWebElement _burgerMenu;
        IWebElement _logOutButton;

        public HomePage(IWebDriver driver) : base(driver)
        {
            _loggedLogo = FindElementBy(LogInOutParams.LOGGED_LOGO);
            _burgerMenu = FindElementBy(LogInOutParams.BURGER_MENU);
            _logOutButton = FindElementBy(LogInOutParams.LOGOUT_BUTTON);
        }
        public bool CheckLoginResult()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _loggedLogo;
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

        public void ClickLogOut()
        {
            _burgerMenu?.Click();
            _logOutButton?.Click();
        }
    }

}
