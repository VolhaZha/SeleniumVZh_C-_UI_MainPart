using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class LoginTest50
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = LoginParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(LoginParams.WAIT_TIME_1);

        }

        [Test]
        [TestCase(LoginParams.NAME1, LoginParams.PASSWORD)]
        [TestCase(LoginParams.NAME2, LoginParams.PASSWORD)]
        public void TestLogin(string username, string password)
        {
            LoginPage50 loginPage = new LoginPage50(driver);
            loginPage.EnterCreds(username, password);

            Assert.IsTrue(loginPage.CheckResult());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
