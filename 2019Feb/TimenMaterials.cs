using System;
using System.Threading;
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

        

        internal void ValidateRecord()
        {
            Thread.Sleep(2000);
            try
            {
                while (true)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        var code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i + "]/td[1]")).Text;
                        Console.WriteLine(code);

                        if ("102938" == code)
                        {
                            Console.WriteLine("Test passed");
                            return;
                        }
                    }
                    driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]/span")).Click();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}