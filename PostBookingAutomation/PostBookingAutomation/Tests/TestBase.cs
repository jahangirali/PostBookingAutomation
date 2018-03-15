using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace PostBookingAutomation.Tests
{
    public class TestBase
    {
       public IWebDriver driver = new ChromeDriver();

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            driver.Navigate().GoToUrl("http://www.119.test/EN/apdrefund.mvc/apd");
        }



        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //driver.Quit();
        }
    }

}
