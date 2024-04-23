using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            driver.Navigate().GoToUrl(MultiSelectParams.URL);

            IWebElement list = driver.FindElement(MultiSelectParams.LIST);
            SelectElement select = new SelectElement(list);

            select.SelectByIndex(0);
            select.SelectByIndex(1);
            select.SelectByValue("Washington");
            select.SelectByText("Texas");

            System.Threading.Thread.Sleep(3000);
            select.DeselectByIndex(0);

            System.Threading.Thread.Sleep(3000);
            IList<IWebElement> allSelected = select.AllSelectedOptions;
            List<string> actualOptionText = new List<string>();
            List<string> expectedOptionText = new List<string> { "Florida", "Texas", "Washington" };
            foreach (IWebElement webElement in allSelected)
            {
                Console.WriteLine(webElement.Text);
                actualOptionText.Add(webElement.Text);
            }
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
