using System;
using _2019Feb.Framework;
using OpenQA.Selenium;

namespace _2019Feb
{
    internal class TimenMaterialsPage
    {
        private IWebDriver driver;

        public TimenMaterialsPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebElement btnCreate =>driver.FindElement(By.XPath("//a[@class='btn btn-primary']"));


        internal void clickCreateNew()
        {

            //***Time n material pages 
            //Click on Create New 
           btnCreate.Click();

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
            //driver.WaitForElement(By.Id("SaveButton"), TimeSpan.FromDays(1));
            driver.FindElement(By.Id("SaveButton")).Click();
        }

        

        internal void ValidateRecord()
        {
            //Thread.Sleep(2000);
            driver.WaitForElement((By.XPath("//a[@class='btn btn-primary']")), TimeSpan.FromSeconds(10));

            Console.WriteLine(btnCreate.Text);

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