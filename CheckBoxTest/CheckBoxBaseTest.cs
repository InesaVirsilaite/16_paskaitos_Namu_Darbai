
using NUnit.Framework;
using OpenQA.Selenium.Edge;
using System;
using OpenQA.Selenium;
using NewDemoProject.Test;

namespace ManoDaktarasPageTesting.Test
{
    public class CheckBoxBaseTest
    {
        protected static IWebDriver webdriver;
        protected static CheckboxDemoPage page;
      
        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            webdriver = new EdgeDriver();
            page = new CheckboxDemoPage(webdriver);
            webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            webdriver.Manage().Window.Maximize();
        }
        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            // driver.Quit();
        }




    }
}
