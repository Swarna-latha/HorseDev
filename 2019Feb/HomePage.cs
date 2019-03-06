using System;
using OpenQA.Selenium;

namespace _2019Feb
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickAdministration()
        {
            //***Home Page
            //click on adminstration 
            driver.FindElement(By.XPath("//li[5]/a[@class='dropdown-toggle' and 1 and @role='button']")).Click();
        }

        internal void ClickTimenMaterials()
        {
            //click on time and material
            driver.FindElement(By.XPath("//a[@href='/TimeMaterial']")).Click();
        }
    }
}