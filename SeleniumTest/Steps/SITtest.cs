using TechTalk.SpecFlow;
using Xunit;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTest.Steps
{
    [Binding]
    public sealed class SITtest
    {
        
        static IWebDriver driver;
        static String webAppUri = "https://bpcalculator1-stage.azurewebsites.net";

        [Given(@"launch url")]
        public void launchUrl()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--disable-dev-shm-usage");
            driver = new ChromeDriver(options);
            driver.Url = webAppUri;
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50.00);
        }
        [Given(@"Systolic value (.*)")]
        public void sendKeysToSystolic(String num)
        {
            IWebElement systolic = driver.FindElement(By.Id("BP_Systolic"));
            systolic.Clear();
            systolic.SendKeys(num);
        }

        [Given(@"Diastolic value (.*)")]
        public void sendKeysToDistolic(String num)
        {
            IWebElement diastolic = driver.FindElement(By.Id("BP_Diastolic"));
            diastolic.Clear();
            diastolic.SendKeys(num);
        }

        [When(@"Click submit")]
        public void clickSubmit()
        {
            IWebElement submit = driver.FindElement(By.XPath("//*[@id='form1']/div[3]/input"));
            submit.Click();
        }

        [Then(@"Verfiy the actual value of message is equal to (.*)")]
        public void assertTheMessage(String expected)
        {
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60.00);
            IWebElement resultedBP = driver.FindElement(By.CssSelector("#form1 > div:nth-child(4)"));
            String actual = resultedBP.Text;
            Assert.Equal(expected, actual);
        }
    }
}