using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019Feb.Framework
{
    public static class WebDriverExtensions
    {
        public static void WaitForElement(this IWebDriver driver,By element, TimeSpan timeSpan)
        {
            var wait = new WebDriverWait(driver, timeSpan);
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }
    }
}
