using NUnit.Framework;
using FacebookRegisterAndLogin.Pages;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FacebookRegisterAndLogin.Tests
{
    public class Login_Test:MainTest
    {
        Login_Page _LoginPage;

        [SetUp]
        public void LoginSetUp()
        {
            _LoginPage = new Login_Page(driver);
        }

        [Test]
        public void LoginWithValidUsernameAndPass()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //Arrange
            String username = "testing_xsyfesb_facebook@tfbnw.net";
            String password = "test@421";

            //Act
            _LoginPage.InsertUsernameAndPass(username, password);

            //Assert
            string Actualtext = _LoginPage.LoginConfirmationText();
            Assert.AreEqual(Actualtext, "Testing User for Facebook");
           
        }
    }
}
