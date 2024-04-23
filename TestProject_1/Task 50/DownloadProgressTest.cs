﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using PageObjectModelsProject_1.Task_50;

namespace TestProject_1.Task_50
{
    public class DownloadProgressTest
    {
        public WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = AlertParams.URL;
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(AlertParams.WAIT_TIME_1);

        }

        [Test, Order(1)]
        public void WaitForUserTest()
        {
                driver.Navigate().GoToUrl(DownloadProgressParams.URL);

                IWebElement downloadButton = driver.FindElement(DownloadProgressParams.DOWNLOAD_BUTTON);
                downloadButton.Click();

                System.Threading.Thread.Sleep(5000);

                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(6));
                var element = wait.Until(condition =>
                {
                    try
                    {
                        var elementToBeDisplayed = driver.FindElement(DownloadProgressParams.LINK_TO_PERCENTAGE);
                        return elementToBeDisplayed.Displayed;
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

                driver.Navigate().Refresh();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Dispose();
        }
    }
}