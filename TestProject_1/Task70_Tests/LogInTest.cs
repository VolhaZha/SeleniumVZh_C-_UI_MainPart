using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task70_Pages;
using NUnit.Allure.Core;

namespace PageObjectModelsProject_1.Task70_Tests
{
    [AllureNUnit]
    public class LogInTest
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = LogInOutParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(LogInOutParams.WAIT_TIME_1);
        }

        [Test]
        [TestCase(LogInOutParams.NAME1, LogInOutParams.PASSWORD)]
        public void TestLogin(string username, string password)
        {
            LogInPage loginPage = new LogInPage(driver);
            loginPage.EnterCreds(username, password);

            HomePage homePage = new HomePage(driver);
            Assert.IsTrue(homePage.CheckLoginResult());

            HomePage homePage2 = new HomePage(driver);
            homePage2.TakeScreen();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }

    }
}
