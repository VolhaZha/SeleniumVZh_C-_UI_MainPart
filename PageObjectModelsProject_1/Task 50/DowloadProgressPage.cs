using OpenQA.Selenium;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50
{
    public class DowloadProgressPage : BasePage
    {
        public DowloadProgressPage(IWebDriver driver) : base(driver)
        {
        }

        public void WaitForUser()
        {
            _driver.Navigate().GoToUrl(DownloadProgressParams.URL);

            IWebElement downloadButton = FindElementBy(DownloadProgressParams.DOWNLOAD_BUTTON);
            downloadButton.Click();
        }
    }
}
