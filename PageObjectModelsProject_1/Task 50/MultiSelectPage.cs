using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50 
{
    public class MultiSelectPage : BasePage
    {
        public MultiSelectPage(IWebDriver driver) : base(driver)
        {
        }

        public void MultiSelect()
        {
            IWebElement list = FindElementBy(MultiSelectParams.LIST);
            SelectElement select = new SelectElement(list);

            select.SelectByIndex(0);
            select.SelectByIndex(1);
            select.SelectByValue("Washington");
            select.SelectByText("Texas");

            System.Threading.Thread.Sleep(3000);
            select.DeselectByIndex(0);

            System.Threading.Thread.Sleep(3000);
        }

    }
}
