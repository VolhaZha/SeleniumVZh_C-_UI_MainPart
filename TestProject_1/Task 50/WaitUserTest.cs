using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;
using OpenQA.Selenium.Support.UI;

namespace TestProject_1.Task_50
{
    public class WaitUserTest
    {
        public WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = AlertParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(AlertParams.WAIT_TIME_1);

        }

        [Test, Order(1)]
        public void WaitForUserTest()
        {
            driver.Navigate().GoToUrl(WaitUserParams.URL);

            IWebElement getNewUserButton = driver.FindElement(WaitUserParams.LINK_TO_GET_NEW_USER);
            getNewUserButton.Click();

            System.Threading.Thread.Sleep(5000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
            var element = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = driver.FindElement(WaitUserParams.EXPLICIT_WAIT_SELECTOR);
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
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
