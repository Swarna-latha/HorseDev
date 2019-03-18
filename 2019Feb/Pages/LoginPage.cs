using _2019Feb.Framework.Libs;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace _2019Feb
{
    internal class LoginPage
    {
        private IWebDriver driver;
               
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
     
        IWebElement txtUserName => driver.FindElement(By.Id("UserName"));
        IWebElement txtPassword => driver.FindElement(By.Name("Password"));
        IWebElement btnLogin => driver.FindElement(By.XPath("//input[@class='btn btn-default']"));

        internal void LoginSucess()
        {
            //*** Login Page
            //Identyfying and sending the username 
            //txtUserName.SendKeys("hari");
            txtUserName.SendKeys(ExcelLib.ReadData(2, "UserName"));


            //Identfying password element
            //enter password
            txtPassword.SendKeys("123123");

            //Click log in 
            btnLogin.Click();
        }

        //Demonstrate the reusability of elments.
        internal void Someothermethod()
        {
            txtUserName.SendKeys("");
        }
       
    }
}