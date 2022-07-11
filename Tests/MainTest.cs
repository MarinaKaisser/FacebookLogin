using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookRegisterAndLogin.Tests
{
    public class MainTest
    {
        public static IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void TestInit()
        {
            //driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TestEnd()
        {
           driver.Close();
        }


    }
}
