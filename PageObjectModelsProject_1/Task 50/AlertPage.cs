using OpenQA.Selenium;
using SeleniumVZhTestProject_1;

namespace PageObjectModelsProject_1.Task_50
{
    public class AlertPage : BasePage
    {
        public AlertPage(IWebDriver driver) : base(driver)
        {
        }

        public void ConfirmOk()
        {
            _driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = FindElementBy(AlertParams.BUTTON_CLICK_ME_CONFIRM);
            clickMeAlert.Click();
        }

        public void AlertAccept()
        {
            Thread.Sleep(5000);
            _driver.SwitchTo().Alert().Accept();
        }

        public void ConfirmCancel()
        {
            _driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = FindElementBy(AlertParams.BUTTON_CLICK_ME_CONFIRM);
            clickMeAlert.Click();
        }

        public void AlertDismiss()
        {
            Thread.Sleep(5000);
            _driver.SwitchTo().Alert().Dismiss();
        }

        public void Prompt()
        {
            _driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickForPromptAlert = FindElementBy(AlertParams.BUTTON_CLICK_FOR_PROMPT);
            clickForPromptAlert.Click();
        }

        public void AlertSendKeys()
        {
            _driver.SwitchTo().Alert().SendKeys("OZ");
            _driver.SwitchTo().Alert().Accept();
        }

        public void Alert()
        {
            _driver.Navigate().GoToUrl(AlertParams.URL);

            IWebElement clickMeAlert = FindElementBy(AlertParams.BUTTON_CLICK_ME_ALERT);
            clickMeAlert.Click();
        }
    }
}
