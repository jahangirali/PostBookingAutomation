using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;

namespace PostBookingAutomation.Tests
{
    public class TestBase
    {
        public IWebDriver driver { get; set; }
        public ApdRequestPage apdRequestPage { get; set; }

        [OneTimeSetUp]

        public void OneTimeSetup()
        {
            driver = new ChromeDriver();
            //driver = new FirefoxDriver();
        }

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("http://www.119.test/EN/apdrefund.mvc/apd");
            apdRequestPage = new ApdRequestPage(driver);
        }



        [TearDown]
        public void OneTimeTearDown()
        {
            //driver?.Quit();
        }
    }

}
