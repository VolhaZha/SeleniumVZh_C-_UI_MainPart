using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task70_Pages;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task120_Pages
{
    public class SL_HomePage : BasePage
    {
        IWebElement _loggedLogo;
        IWebElement _burgerMenu;
        IWebElement _logOutButton;

        public SL_HomePage(IWebDriver driver) : base(driver)
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

        public void TakeScreen()
        {
            Screenshot screenshot = (_driver as ITakesScreenshot).GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\OlgaZhavrid\Downloads\screenshot.png");
        }
    }
}
