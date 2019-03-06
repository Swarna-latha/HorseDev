using System;
using OpenQA.Selenium;

namespace _2019Feb
{
    internal class TimenMaterials
    {
        private IWebDriver driver;

        public TimenMaterials(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void clickCreateNew()
        {

            //***Time n material pages 
            //Click on Create New 
            driver.FindElement(By.XPath("//a[@class='btn btn-primary']")).Click();

        }

        internal void EnterValidDetails()
        {
            //Enter code 
            driver.FindElement(By.Id("Code")).SendKeys("okay");

            //Enter description
            driver.FindElement(By.Id("Description")).SendKeys("some description");

            //price per unit
            driver.FindElement(By.XPath("//input[@class='k-formatted-value k-input']")).SendKeys("9.99");

            //  click save
            driver.FindElement(By.Id("SaveButton")).Click();
        }
    }
}