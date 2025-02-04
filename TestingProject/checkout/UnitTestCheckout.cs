using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumTests
{
    [TestFixture]
    public class Checkout
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.That(verificationErrors.ToString(), Is.Empty);
        }

        [Test]
        public void TheCheckoutTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.LinkText("Log in")).Click();
            driver.FindElement(By.Id("Email")).Click();
            driver.FindElement(By.Id("Email")).Clear();
            driver.FindElement(By.Id("Email")).SendKeys("llcccc@net.hr");
            driver.FindElement(By.Id("Password")).Click();
            driver.FindElement(By.Id("Password")).Clear();
            driver.FindElement(By.Id("Password")).SendKeys("blablabla");
            driver.FindElement(By.Id("RememberMe")).Click();
            driver.FindElement(By.XPath("//input[@value='Log in']")).Click();
            driver.FindElement(By.XPath("//li[@id='topcartlink']/a/span")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            driver.FindElement(By.Id("checkout")).Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            IWebElement billAdress = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("BillingNewAddress_CountryId")));
            billAdress.Click();
            new SelectElement(driver.FindElement(By.Id("BillingNewAddress_CountryId"))).SelectByText("Croatia");
            driver.FindElement(By.Id("BillingNewAddress_City")).Click();
            driver.FindElement(By.Id("BillingNewAddress_City")).Clear();
            driver.FindElement(By.Id("BillingNewAddress_City")).SendKeys("Osijek");
            driver.FindElement(By.Id("BillingNewAddress_Address1")).Click();
            driver.FindElement(By.Id("BillingNewAddress_Address1")).Clear();
            driver.FindElement(By.Id("BillingNewAddress_Address1")).SendKeys("Ulica Vatrenih 29");
            driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).Click();
            driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).Clear();
            driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode")).SendKeys("31000");
            driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).Click();
            driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).Clear();
            driver.FindElement(By.Id("BillingNewAddress_PhoneNumber")).SendKeys("123456789");
            driver.FindElement(By.XPath("//input[@value='Continue']")).Click();
            IWebElement shipping = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@onclick='Shipping.save()']")));
            shipping.Click();
            IWebElement shippingMethod = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@class='button-1 shipping-method-next-step-button']")));
            shippingMethod.Click();
            IWebElement paymentMethod = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@class='button-1 payment-method-next-step-button']")));
            paymentMethod.Click();         
            IWebElement paymentInfo = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@class='button-1 payment-info-next-step-button']")));
            paymentInfo.Click();          
            IWebElement confirm = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Confirm']")));
            confirm.Click();
            IWebElement finish = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@value='Continue']")));
            finish.Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
