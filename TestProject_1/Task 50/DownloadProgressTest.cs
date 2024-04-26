using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;
using OpenQA.Selenium.Support.UI;

namespace TestProject_1.Task_50
{
    public class DownloadProgressTest
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
            DowloadProgressPage dowloadProgressPage = new DowloadProgressPage(driver);
            dowloadProgressPage.WaitForUser();

            System.Threading.Thread.Sleep(5000);

            

            Assert.IsTrue(dowloadProgressPage.CheckProgress());

            driver.Navigate().Refresh();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
