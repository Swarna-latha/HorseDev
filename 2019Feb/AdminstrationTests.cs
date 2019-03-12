using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Feb
{
    class AdminstrationTests
    {
        IWebDriver driver;
        [SetUp]
        public void setup()
        {
            // Creating a new Chrome Driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            var loginPage = new LoginPage(driver);
            loginPage.LoginSucess();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CreateandValidateTimenMaterialTests()
        {        
            var home = new HomePage(driver);
            home.ClickAdministration();
            home.ClickTimenMaterials();

            var time = new TimenMaterials(driver);
            time.clickCreateNew();
            time.EnterValidDetails();
            time.ValidateRecord();           
        }

        [Test]
        public void EditnValidate()
        {
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //var loginPage = new LoginPage(driver);
            //loginPage.LoginSucess();


            var home = new HomePage(driver);
            home.ClickAdministration();
            home.ClickTimenMaterials();
            //Create logc to edit and validate

            //driver.Quit();
        }

        [Test]
        public void DeletenValidate()
        {

            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //var loginPage = new LoginPage(driver);
            //loginPage.LoginSucess();


            var home = new HomePage(driver);
            home.ClickAdministration();
            home.ClickTimenMaterials();

            //Create logc to delete and validate

            //driver.Quit();
        }
    }
}
