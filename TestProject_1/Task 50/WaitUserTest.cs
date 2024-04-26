using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class WaitUserTest
    {
        public WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = WaitUserParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(AlertParams.WAIT_TIME_1);

        }

        [Test, Order(1)]
        public void WaitForUserTest()
        {
            WaitUserPage waitUserPage = new WaitUserPage(driver);
            waitUserPage.WaitForUser();

            Assert.IsTrue(waitUserPage.CheckResult());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
