using OpenQA.Selenium;
using SeleniumVZhTestProject_1;
using System.Text.RegularExpressions;

namespace PageObjectModelsProject_1.Task_50
{
    public class ReturnObjectListPage : BasePage
    {
        public ReturnObjectListPage(IWebDriver driver) : base(driver)
        {
           
        }

        public String ReturnObjectListText()
        {
            IWebElement listNumberOption = FindElementBy(ReturnObjectListParams.LIST_OPTION10);
            listNumberOption.Click();

            System.Threading.Thread.Sleep(1000);

            List<CustomObject> customObjectsList = new List<CustomObject>();
            bool isButtonDisabled = FindElementBy(ReturnObjectListParams.NEXTBUTTON).GetAttribute("class").Contains("disabled");
            while (!isButtonDisabled)
            {
                IList<IWebElement> rows = _driver.FindElements(ReturnObjectListParams.ROWS);
                IWebElement nextButton;

                foreach (IWebElement row in rows)
                {
                    IList<IWebElement> cells = row.FindElements(ReturnObjectListParams.CELLS);
                    string name = cells[0].Text;
                    string position = cells[1].Text;
                    string office = cells[2].Text;
                    int ageValue = int.Parse(cells[3].Text);
                    string salaryText = Regex.Replace(cells[5].Text, "[^0-9]", "");
                    int salaryValue = int.Parse(salaryText);


                    int x = 18;
                    int y = 400000;

                    if (ageValue > x && salaryValue <= y)
                    {
                        CustomObject customObject = new CustomObject(name, position, office);
                        customObjectsList.Add(customObject);
                    }
                }

                isButtonDisabled = _driver.FindElement(ReturnObjectListParams.NEXTBUTTON).GetAttribute("class").Contains("disabled");
                nextButton = _driver.FindElement(ReturnObjectListParams.NEXTBUTTON);
                nextButton.Click();
                System.Threading.Thread.Sleep(1000);
            }

            foreach (CustomObject customObject in customObjectsList)
            {
                Console.WriteLine(customObject.Name + ", " + customObject.Position + ", " + customObject.Office);
            }

            CustomObject firstPerson = customObjectsList[0];
            string expectedText = firstPerson.Name + ", " + firstPerson.Position + ", " + firstPerson.Office;

            return expectedText;
        }
    }
}
