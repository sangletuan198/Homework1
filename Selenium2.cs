using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Homework1
{
    public class Scenario1
    {
        IWebDriver _driver;
      
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
<<<<<<< HEAD
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

=======
>>>>>>> f82bdba198d520708f02406979ccb61457c58af1
        }

        [Test]
        public void Test1()
        {
            _driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            _driver.Manage().Window.Maximize();
            Console.WriteLine("web open successfully");

<<<<<<< HEAD
           
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            IWebElement searchResult = wait.Until(ExpectedConditions.ElementExists(By.XPath("//*[@title=\"Contact us\"]")));
=======
>>>>>>> f82bdba198d520708f02406979ccb61457c58af1
            IWebElement contactUs = _driver.FindElement(By.XPath("//*[@title=\"Contact us\"]"));
            contactUs.Click();
            string actualTitle1 = _driver.Title;
            string expectedTitle1 = "Contact us - My Store";
            Console.WriteLine("title1 = " + actualTitle1);
            Assert.AreEqual(expectedTitle1, actualTitle1);

            IWebElement f = _driver.FindElement(By.XPath("//*[@id='search_query_top']"));
            IJavaScriptExecutor scoll = (IJavaScriptExecutor)_driver;
            scoll.ExecuteScript("arguments[0].scrollIntoView(false);", f);

            Thread.Sleep(3000);

<<<<<<< HEAD
            _driver.Navigate().Back(); 
=======
            _driver.Navigate().Back();
>>>>>>> f82bdba198d520708f02406979ccb61457c58af1

            string actualTitle2 = _driver.Title;
            string expectedTitle2 = "My Store";
            Assert.AreEqual(expectedTitle2, actualTitle2);
            Console.WriteLine("title2 = " + actualTitle2);

            IWebElement g = _driver.FindElement(By.XPath("//*[@id='search_query_top']"));
            IJavaScriptExecutor sscoll = (IJavaScriptExecutor)_driver;
            sscoll.ExecuteScript("arguments[0].scrollIntoView(false);", g);

            Thread.Sleep(3000);
            
        }
        [TearDown]
        public void close_Browser()
        {
            _driver.Quit();
        }

    }
}