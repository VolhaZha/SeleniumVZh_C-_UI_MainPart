using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task_50
{
    public class DownloadProgressParams
    {
        public static int WAIT_TIME_1 = 1;

        public const string URL = "https://demo.seleniumeasy.com/bootstrap-download-progress-demo.html";
        
        public static By DOWNLOAD_BUTTON = By.XPath("//*[@id=\"cricle-btn\"]");
        public static By LINK_TO_PERCENTAGE = By.XPath("//div[@class='percenttext']");
    }
}
