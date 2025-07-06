using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;
using System.IO;

namespace AutomationTestProject
{
    internal class DriverFactory
    {
        public static IWebDriver GetDriver(string browser)
        {
            switch (browser.ToLower())
            {
                case "chrome":
                    return GetChromeDriver();
                case "firefox":
                    return GetFirefoxDriver();
                case "edge":
                    return GetEdgeDriver();
                default:
                    throw new ArgumentException($"Browser '{browser}' is not supported.");
            }
        }

        private static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(@"C:\Users\miros\source\repos\AutomationTestProject\WebDrivers\Chrome");
        }

        private static IWebDriver GetFirefoxDriver()
        {
            return new FirefoxDriver(@"C:\Users\miros\source\repos\AutomationTestProject\WebDrivers\Firefox");
        }

        private static IWebDriver GetEdgeDriver()
        {
            return new EdgeDriver(@"C:\Users\miros\source\repos\AutomationTestProject\WebDrivers\Edge");
        }
    }
}
