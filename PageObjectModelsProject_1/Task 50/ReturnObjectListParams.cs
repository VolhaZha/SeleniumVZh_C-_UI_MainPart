using OpenQA.Selenium;

namespace PageObjectModelsProject_1.Task_50
{
    public class ReturnObjectListParams
    {
        public static int WAIT_TIME_1 = 1;

        public const string URL = "https://demo.seleniumeasy.com/table-sort-search-demo.html";
        public static  By LIST_OPTION10 = By.XPath("//*[@id='example_length']/label/select/option[1]");
        public static  By ROWS = By.XPath("//table[@id='example']/tbody/tr");
        public static  By CELLS = By.TagName("td");
        public static  By NEXTBUTTON = By.XPath("//*[@id='example_next']");
    }
}
