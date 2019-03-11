using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace _2019Feb
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a new Chrome Driver
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            var loginPage = new LoginPage(driver);
            loginPage.LoginSucess();


            var home = new HomePage(driver);
            home.ClickAdministration();
            home.ClickTimenMaterials();

            var time = new TimenMaterials(driver);
            time.clickCreateNew();
            time.EnterValidDetails();
            time.ValidateRecord();

            //driver.Quit();

            
        }

    }
}
