using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task_50
{
    public class WaitUserParams
    {
        public static int WAIT_TIME_1 = 1;

        public const string URL = "https://demo.seleniumeasy.com/dynamic-data-loading-demo.html";

        public static By LINK_TO_GET_NEW_USER = By.XPath("//*[@id=\"save\"]");

        public static By EXPLICIT_WAIT_SELECTOR = By.XPath("//*[@id=\"loading\"]");
    }
}
