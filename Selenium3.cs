using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace Homework1
{
    internal class Selenium3
    {
        private readonly IWebDriver? _driver;
        public Selenium3 (IWebDriver driver)
        {
            _driver = driver;
        }
        //locators
        private readonly String url = "https://www.google.com.vn/";
        private readonly By searchBox = By.XPath("//*[@class='gLFyf gsfi']");
        private readonly String keyword = "selenium";
        private readonly By searchButton = By.XPath("//div[@jsname='VlcLAe']/center/input[@class='gNO89b']");
        private readonly By firstResult = By.XPath("//*[@class='LC20lb MBeuO DKV0Md'][1]");
        //elements
        public IWebElement getSearchBox() { return _driver.FindElement(searchBox);}
        public IWebElement getSearchButton() { return _driver.FindElement(searchButton);}   
        
        //method
       public Selenium3 GetToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return this;
        }
        public Selenium3 SendKeyWord(string keyword)
        {
            getSearchBox()?.Clear();
            getSearchBox()?.SendKeys(keyword);
            return this;
        }
        public Selenium3 ClickSearch(By seachButton)
        {
            getSearchButton()?.Click();
            return this;
        }
        public Selenium3 VerifyTitle()
        {
            string actualTitle = _driver.Title;
            string expectedTitle = keyword + " - Tìm trên Google";
            Assert.AreEqual(expectedTitle, actualTitle);
            return this;
        }
        public Selenium3 VerifyStElse()
        {
            string actualTitle2 = _driver.Title;
            string expectedTitle2 = keyword;
            Assert.AreEqual(expectedTitle2, actualTitle2);
            return this;
        }
    }
}
