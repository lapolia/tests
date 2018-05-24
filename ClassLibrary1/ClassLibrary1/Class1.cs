using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    [TestFixture]
    public class proga_test
    {
        

        [TestCase]
        public void Title()
        {
            IWebDriver WebDriver = new ChromeDriver();

            WebDriver.Url = "https://adventuretime.ru/";
            Assert.AreEqual("Время приключений - Adventure Time смотреть онлайн", WebDriver.Title);
            
        }
        [TestCase]
        public void Obj()
        {
            IWebDriver WebDriver = new ChromeDriver();

            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div[2]/img"));
            bool status = element.Displayed;
        }
        [TestCase]
        public void Link()
        {
            IWebDriver WebDriver = new ChromeDriver();

            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div/ul/li[3]/a"));
            element.Click();
            

        }

        [TestCase]
        public void Text()
        {
            IWebDriver WebDriver = new ChromeDriver();

            WebDriver.Url = "https://adventuretime.ru/";

           // IWebElement div = WebDriver.FindElement(By.XPath("//*[@id=\"ya - site - form0\"]/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div"));

           // div.Click();

            IWebElement search = WebDriver.FindElement(By.XPath("//*[@id=\"ya - site - form0\"]/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div/input"));
            search.SendKeys("пупырка рулит");

           IWebElement button = WebDriver.FindElement(By.XPath("//*[@id='ya - site - form0']/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[2]/input"));
            
            button.Click();

            WebDriver.Quit();
        }



        [TearDown]
        public void testEnd()
        {
            
        }

        
       





        
    }
}
