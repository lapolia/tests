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
        IWebDriver WebDriver = new ChromeDriver();

        [TestCase]
        public void Title()
        {
            WebDriver.Url = "https://adventuretime.ru/";
            Assert.AreEqual("Время приключений - Adventure Time смотреть онлайн", WebDriver.Title);
        }

        [TestCase]
        public void Obj()
        {
            
            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div[2]/img"));
            bool status = element.Displayed;
        }


        [TestCase]
        public void Link()
        {
            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div/ul/li[3]/a"));
            element.Click();
        }

        IWebDriver WebDriver1 = new ChromeDriver();

        [TestCase]
        public void Text()
        {
            

            WebDriver1.Url = "https://www.sibsutis.ru/";

           // IWebElement div = WebDriver.FindElement(By.XPath("//*[@id=\"ya - site - form0\"]/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div"));

           // div.Click();

            IWebElement search = WebDriver1.FindElement(By.XPath("//*[@id=\"qqq\"]"));
            search.SendKeys("пупырка рулит");

           IWebElement button = WebDriver1.FindElement(By.XPath("//*[@id=\"layout\"]/div[2]/div[2]/div[2]/div[3]/form/input[2]"));
            
            button.Click();
           

        }



        [TearDown]
        public void testEnd()
        {
            WebDriver.Quit();
            WebDriver1.Quit();
        }

        
    }
}
