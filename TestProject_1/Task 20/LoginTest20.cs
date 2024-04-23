using NUnit.Framework.Internal;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace SeleniumVZhTestProject_1
{
    public class LoginTest20
    {
        private WebDriver driver;
        private const string NAME = "v_z_2025";
        private const string PASSWORD = "123456vz12345";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://mail.ru/";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void TestLogin()
        {
        HomePage20 homePage = new HomePage20(driver);
        homePage.GoToLoginWindow();

        LoginPage20 loginPage = new LoginPage20(driver);
        loginPage.EnterCreds(NAME, PASSWORD);
        Assert.IsTrue(loginPage.LogInSuccess());
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}
