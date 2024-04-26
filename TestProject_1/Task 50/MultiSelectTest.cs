using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class MultiSelectTest
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = MultiSelectParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(MultiSelectParams.WAIT_TIME_1);

        }

        [Test]
        public void MultiSelect()
        {
            List<string> actualOptionText = new List<string>();
            List<string> expectedOptionText = new List<string> { "Florida", "Texas", "Washington" };
            MultiSelectPage multiSelectPage = new MultiSelectPage(driver);
            actualOptionText = multiSelectPage.MultiSelect();
            Assert.AreEqual(expectedOptionText, actualOptionText, "Selected option doesn't match expected option");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }

    }
}
