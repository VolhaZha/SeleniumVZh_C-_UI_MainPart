using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
        public bool CheckProgress()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(6));
            var result = wait.Until(condition =>
            {
                try
                {
                    var elementToBeDisplayed = _driver.FindElement(DownloadProgressParams.LINK_TO_PERCENTAGE);
                    return int.Parse(elementToBeDisplayed.Text.Remove(2)) >= 50;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });
            return result;
        }
    }
}
