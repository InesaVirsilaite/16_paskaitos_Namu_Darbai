using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using NewDemoProject.Test;
using OpenQA.Selenium.Edge;

namespace ManoDaktarasPageTesting.Test
{
    public class CheckBoxTest: CheckBoxBaseTest
    {

       
        public static void TestCheckBox()
        {
            CheckboxDemoPage page = new CheckboxDemoPage(webdriver);

            page.navigateToPage();
            page.OneCheckboxTest();
            page.UncheckCheckboxesTest();
            page.CheckAllChekboxes();



        }
    }
}