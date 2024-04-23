using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class AlertTestF
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
        public void TestConfirmOk()
        {
            driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = driver.FindElement(AlertParams.BUTTON_CLICK_ME_CONFIRM);
            clickMeAlert.Click();

            string expectedAlertText = "Press a button!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();
        }

        [Test, Order(2)]
        public void TestConfirmCancel()
        {
            driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = driver.FindElement(AlertParams.BUTTON_CLICK_ME_CONFIRM);
            clickMeAlert.Click();

            string expectedAlertText = "Press a button!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Dismiss();
        }

        [Test, Order(4)]
        public void TestPrompt()
        {
            driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickForPromptAlert = driver.FindElement(AlertParams.BUTTON_CLICK_FOR_PROMPT);
            clickForPromptAlert.Click();

            string expectedAlertText = "Please enter your name";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().SendKeys("OZ");
            driver.SwitchTo().Alert().Accept();
        }

        [Test, Order(3)]
        public void TestAlert()
        {
            driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = driver.FindElement(AlertParams.BUTTON_CLICK_ME_ALERT);
            clickMeAlert.Click();

            string expectedAlertText = "I am an alert box!";
            string actualAlertText = driver.SwitchTo().Alert().Text;
            Assert.AreEqual(expectedAlertText, actualAlertText);

            Thread.Sleep(5000);

            driver.SwitchTo().Alert().Accept();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
