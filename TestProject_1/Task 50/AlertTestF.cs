using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class AlertTestF
    {
        private WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = AlertParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(AlertParams.WAIT_TIME_1);
        }

        [Test, Order(1)]
        public void TestConfirmOk()
        {
            AlertPage alertPage = new AlertPage(driver);
            alertPage.ConfirmOk();
          
            string expectedAlertText = "Press a button!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            alertPage.AlertAccept();
        }

        [Test, Order(2)]
        public void TestConfirmCancel()
        {
            AlertPage alertPage = new AlertPage(driver);

            alertPage.ConfirmCancel();

            string expectedAlertText = "Press a button!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            alertPage.AlertDismiss();
        }

        [Test, Order(4)]
        public void TestPrompt()
        {
            AlertPage alertPage = new AlertPage(driver);

            alertPage.Prompt();

            string expectedAlertText = "Please enter your name";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            alertPage.AlertSendKeys();
        }

        [Test, Order(3)]
        public void TestAlert()
        {
            AlertPage alertPage = new AlertPage(driver);

            alertPage.Alert();

            string expectedAlertText = "I am an alert box!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            alertPage.AlertAccept();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
