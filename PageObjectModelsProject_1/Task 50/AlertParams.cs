using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task_50
{
    public class AlertParams
    {
        public static int WAIT_TIME_1 = 1;

        public const string URL = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";

        public static By BUTTON_CLICK_ME_ALERT = By.XPath("//*[@id=\"easycont\"]/div/div[2]/div[1]/div[2]/button");
        public static By BUTTON_CLICK_FOR_PROMPT = By.XPath("//*[@id=\"easycont\"]/div/div[2]/div[3]/div[2]/button");

        public static By BUTTON_CLICK_ME_CONFIRM = By.XPath("//*[@id=\"easycont\"]/div/div[2]/div[2]/div[2]/button");
    }
}
