using OpenQA.Selenium.Chrome;
using PageObjectModelsProject_1.Task70_Pages;
using OpenQA.Selenium.Remote;
using PageObjectModelsProject_1.Task120_Pages;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;

namespace TestProject_1.Task120_Tests
{
    [TestFixture("Windows 10", "Edge", "latest")]
    [TestFixture("Windows 8.1", "Firefox", "latest")]
    [TestFixture("macOS 13", "Chrome", "latest")]
    public class SL_BaseTest
    {
        public RemoteWebDriver driver = null;
        public const string USERNAME = "oauth-olgazhauryd-6462d";
        public const string KEY = "6f3750e7-abbb-4500-90c4-99103e90a21c";
        public const string URL = "https://" + USERNAME + ":" + KEY+ "@ondemand.eu-central-1.saucelabs.com:443/wd/hub";

        private string platform;
        private string browser;
        private string version;

        public SL_BaseTest(string platform, string browser, string version)
        {
            this.platform = platform;
            this.browser = browser;
            this.version = version;
        }

        [SetUp]
        public void Setup()
        {
            var sauceOptions = new Dictionary<string, object>
            {
                { "username", USERNAME },
                { "accessKey", KEY }
            };

            if (browser == "Edge")
            {
                var browserOptions = new EdgeOptions
                {
                    PlatformName = platform,
                    BrowserVersion = version
                };
                browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
                driver = new RemoteWebDriver(new Uri(URL), browserOptions);
            }
            if (browser == "Firefox")
            {
                var browserOptions = new FirefoxOptions
                {
                    PlatformName = platform,
                    BrowserVersion = version
                };
                browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
                driver = new RemoteWebDriver(new Uri(URL), browserOptions);
            }
            if (browser == "Chrome")
            {
                var browserOptions = new ChromeOptions
            {
                PlatformName = platform,
                BrowserVersion = version
            };
            browserOptions.AddAdditionalOption("sauce:options", sauceOptions);
            driver = new RemoteWebDriver(new Uri(URL), browserOptions);
            }

            driver.Url = SL_LogInOutParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(SL_LogInOutParams.WAIT_TIME_1);
        }


        [Test]
        [TestCase(LogInOutParams.NAME1, LogInOutParams.PASSWORD)]
        public void TestLogin(string username, string password)
        {
            SL_LogInPage loginPage = new SL_LogInPage(driver);
            loginPage.EnterCreds(username, password);

            SL_HomePage homePage = new SL_HomePage(driver);
            Assert.IsTrue(homePage.CheckLoginResult());

            SL_HomePage homePage2 = new SL_HomePage(driver);
            homePage2.TakeScreen();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }

    }
}
