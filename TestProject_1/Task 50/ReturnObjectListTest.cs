using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;
using System.Text.RegularExpressions;

namespace TestProject_1.Task_50
{
    public class ReturnObjectListTest
    {
        public WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = ReturnObjectListParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(AlertParams.WAIT_TIME_1);

        }

        [Test, Order(1)]
        public void WaitForUserTest()
        {
            string actualText = "A. Cox, Junior Technical Author, San Francisco";
            ReturnObjectListPage returnObjectListPage = new ReturnObjectListPage(driver);
            string expectedText = returnObjectListPage.ReturnObjectListText();

            Assert.AreEqual(expectedText, actualText);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
