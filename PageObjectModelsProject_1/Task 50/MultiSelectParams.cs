using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task_50
{
    public class MultiSelectParams
    {
        public const string URL = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        public static By LIST = By.XPath("//*[@id=\"multi-select\"]");
        public static int WAIT_TIME_1 = 1;
    }
}
