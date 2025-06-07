using AngleSharp.Html.Dom;
using AutomationTestProject.BASE;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTestProject.TESTS
{
    [TestClass]
    public class Products
    {
        IWebElement element;
        IWebDriver driver = new FirefoxDriver();

        string title;
        string expectedTitle = Validations.EXPECTED_TITLE;
        string actualName = Validations.ACTUAL_NAME;
        string url = UserData.URL;
        string userNameField = Locators.USERNAME_FIELD;
        string passwordField = Locators.PASSWORD_FIELD;
        string userName = UserData.USER_NAME;
        string password = UserData.PASSWORD;    
        string loginBTN = Locators.LOGIN_BTN;
        string productToAdd = Locators.PRODUCT_TO_ADD;
        string shoppingCard = Locators.SHOPPING_CARD;
        string productName = Validations.PRODUCT_NAME;
        string sortingDropDown = Locators.SORTING_DROP_DOWN;

        [TestMethod]
        public void AddProductTest()
        {
            /*
             * To-do
             * Handle the Google password alert
             */
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
            title = driver.Title;
            Assert.AreEqual(expectedTitle, title);

            element = driver.FindElement(By.Id(productToAdd));
            element.Click();
            element = driver.FindElement(By.ClassName(shoppingCard));
            element.Click();
            element = driver.FindElement(By.ClassName(productName));
            productName = element.Text;
            Assert.AreEqual(actualName, productName);

            driver.Quit();
        }

        [TestMethod]
        public void SortProducts()
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

            title = driver.Title;
            Assert.AreEqual(expectedTitle, title);

            element = driver.FindElement(By.XPath(sortingDropDown));
            element.Click();

            driver.Quit();
        }
    }
}
