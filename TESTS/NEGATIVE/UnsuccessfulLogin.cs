using AutomationTestProject.BASE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationTestProject.TESTS.NEGATIVE
{
    [TestClass]
    public class UnsuccessfulLogin
    {
        IWebElement element;
        IWebDriver driver = DriverFactory.GetDriver("Firefox");

        string url = UserData.URL;
        string userNameField = Locators.USERNAME_FIELD;
        string passwordField = Locators.PASSWORD_FIELD;
        string loginBTN = Locators.LOGIN_BTN;
        string fakeUserName = UserData.FAKE_USER_NAME;
        string fakepassword = UserData.FAKE_PASSWORD;
        string warning = Locators.WARNING;
        string expectedWarningText = UserData.WARNING_TEXT;
        string warningText;

        [TestMethod]
        public void UnsuccessfulLoginTest()
        {

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.FullScreen();

            element = driver.FindElement(By.Id(userNameField));
            element.Click();
            element.SendKeys(fakeUserName);

            element = driver.FindElement(By.Id(passwordField));
            element.Click();
            element.SendKeys(fakepassword);

            element = driver.FindElement(By.Id(loginBTN));
            element.Click();

            element = driver.FindElement(By.CssSelector(warning));
            warningText = element.Text;
            Assert.AreEqual(expectedWarningText, warningText);

            driver?.Quit();
        }
    }
}
