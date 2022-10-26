using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;


namespace Homework1
{
    public class SearchPage
    {
        protected readonly IWebDriver? _driver;
        public SearchPage (IWebDriver driver)
        {
            _driver = driver;
        }
        //locators
        
     
        //elements
        public IWebElement? getSearchBox(By searchBox) { return _driver.FindElement(searchBox);}
        public IWebElement? getSearchButton(By searchButton) { return _driver.FindElement(searchButton);}
        public IWebElement? getFirstResult(By firstResult) { return _driver.FindElement(firstResult);}

        //method
       public SearchPage GetToPage(string url)
        {
            _driver.Navigate().GoToUrl(url);
            return this;
        }
      
        public SearchPage VerifyTitle(string title)
        {
            string actualTitle = _driver.Title;
            string expectedTitle = title + " - Tìm trên Google";
            Assert.AreEqual(expectedTitle, actualTitle);
            return this;
        }
        
    }
    
}
