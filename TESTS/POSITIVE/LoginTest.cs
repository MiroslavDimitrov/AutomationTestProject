using AutomationTestProject.BASE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AutomationTestProject.TESTS
{
    [TestClass]
    public class LoginTest
    {
        IWebElement element;
        IWebDriver driver = new FirefoxDriver();

        string url = UserData.URL;
        string userNameField = Locators.USERNAME_FIELD;
        string passwordField = Locators.PASSWORD_FIELD;
        string userName = UserData.USER_NAME;
        string password = UserData.PASSWORD;
        string loginBTN = Locators.LOGIN_BTN;

        [TestMethod]
        public void loginTest()
        {

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();

            element = driver.FindElement(By.Id(userNameField));
            element.Click();
            element.SendKeys(userName);

            element = driver.FindElement(By.Id(passwordField));
            element.Click();
            element.SendKeys(password);

            element = driver.FindElement(By.Id(loginBTN));
            element.Click();
            driver?.Quit();
        }
    }
}
