using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Homework1
{
    internal class Test : SearchPage
    {
        public Test(IWebDriver driver) : base(driver){  }
        IWebDriver _driver;
        [SetUp]
        public void SetUp()
        {
            _driver = new ChromeDriver();
            
        }
        [Test]
        public void getToPage()
        {
            GetToPage("https://www.google.com.vn/");
            _driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        public void getSearch()
        {
            String keyWord = "facebook";
            By searchBox = By.XPath("//*[@class='gLFyf gsfi']");
            getSearchBox(searchBox).SendKeys(keyWord);           

            By searchButton = By.XPath("//div[@jsname='VlcLAe']/center/input[@class='gNO89b']");
            getSearchButton(searchButton).SendKeys(Keys.Enter);
            VerifyTitle(keyWord);
        }
        public void get1StResult()
        {
            By firstResult = By.XPath("//*[@class='LC20lb MBeuO DKV0Md'][1]");
            getSearchButton(firstResult).SendKeys(Keys.Enter);
        }
        public void get1StResultTitle()
        {
           string actualTitle2= _driver.Title;
            string expectedTitle2 = "Facebook - Đăng nhập hoặc đăng ký";
            Assert.AreEqual(expectedTitle2, actualTitle2);
        }

        [TearDown]
        public void close_Browser()
        {
            _driver.Quit();
        }
    }
}
//private readonly By searchBox = By.XPath("//*[@class='gLFyf gsfi']");
//private readonly By searchButton = By.XPath("//div[@jsname='VlcLAe']/center/input[@class='gNO89b']");
//private readonly By firstResult = By.XPath("//*[@class='LC20lb MBeuO DKV0Md'][1]");
