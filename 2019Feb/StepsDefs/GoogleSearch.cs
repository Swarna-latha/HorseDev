using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace _2019Feb.StepsDefs
{
    [Binding]
    public class GoogleSearchSteps
    {
        IWebDriver driver;
        [Given(@"I am on Google Home page")]
        public void GivenIAmOnGoogleHomePage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
        }
        
        [When(@"I enter Specflow")]
        public void WhenIEnterSpecflow()
        {
            driver.FindElement(By.Name("q")).SendKeys("Specflow");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
        }

        [Then(@"I am taken to the Specflow results")]
        public void ThenIAmTakenToTheSpecflowResults()
        {
            Thread.Sleep(2000);
            Assert.AreEqual("Specflow - Google Search", driver.Title);
            driver.Quit();
        }
    }
}
