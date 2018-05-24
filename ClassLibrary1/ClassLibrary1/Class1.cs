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
            WebDriver.Close();
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
            WebDriver.Navigate().Back();
        }
        [TestCase]
        public void Text()
        {
            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement element = WebDriver.FindElement(By.XPath("//*[@id='ya - site - form0']/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[1]/div/input"));
            element.SendKeys("пупырка рулит");
        
        }
        [TestCase]
        public void Button()
        {
            WebDriver.Url = "https://adventuretime.ru/";
            IWebElement button = WebDriver.FindElement(By.XPath("//*[@id='ya - site - form0']/div/table/tbody/tr/td/table/tbody/tr[1]/td/table/tbody/tr/td[2]/input"));
            button.Click();

        }




        [TearDown]
        public void testEnd()
        {
            WebDriver.Quit();
        }

        
       





        
    }
}
