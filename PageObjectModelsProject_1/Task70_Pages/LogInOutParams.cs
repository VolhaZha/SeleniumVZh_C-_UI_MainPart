using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task70_Pages
{
    public class LogInOutParams
    {
        public static int WAIT_TIME_1 = 1;
        public static By NAME_FIELD = By.XPath("//input[@placeholder='Username']");
        public static By PASS_FIELD = By.XPath("//input[@placeholder='Password']");
        public static By LOGIN_BUTTON = By.ClassName("submit-button");
        public static By LOGGED_LOGO = By.ClassName("app_logo");
        public static By BURGER_MENU = By.ClassName("bm-burger-button");
        public static By LOGOUT_BUTTON = By.XPath("//a[@id='logout_sidebar_link']");


        public const string NAME1 = "standard_user";
        public const string NAME2 = "visual_user";
        public const string PASSWORD = "secret_sauce";

        public const string URL = "https://www.saucedemo.com/";
    }
}
