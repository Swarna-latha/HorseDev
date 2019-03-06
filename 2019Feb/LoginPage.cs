using OpenQA.Selenium;
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

        internal void LoginSucess()
        {
            //*** Login Page
            //Identyfying and sending the username 
            IWebElement txtUserName = driver.FindElement(By.Id("UserName"));
            txtUserName.SendKeys("hari");

            //Identfying password element
            IWebElement txtPassword = driver.FindElement(By.Name("Password"));
            //enter password
            txtPassword.SendKeys("123123");

            //Click log in 
            var btnLogin = driver.FindElement(By.XPath("//input[@class='btn btn-default']"));
            btnLogin.Click();
        }
    }
}