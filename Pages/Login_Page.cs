using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace FacebookRegisterAndLogin.Pages
{
    public class Login_Page
    {
        public IWebDriver driver;

        //Constructor
        public Login_Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        //Elements
        public IWebElement Email_()
        {
            return driver.FindElement(By.Id("email"));
        }

        public IWebElement Password_()
        {
            return driver.FindElement(By.Id("pass"));
        }

        public IWebElement Login_Button()
        {
            return driver.FindElement(By.XPath("//button[starts-with(@data-testid,'royal_login_button')]"));
        }

        public string LoginConfirmationText()
        {
            //Thread.Sleep(100);
            return driver.FindElement(By.XPath("//*[text()='Testing User for Facebook']")).Text;

            //   return driver.FindElement(By.XPath("//a[starts-with(@href,'https://www.facebook.com/?sk=welcome')]"));
            //   return driver.FindElement(By.LinkText("https://www.facebook.com/?sk=welcome"));
        }

        //Methods
        public void Insert_Email(string email_value)
        {
            Console.WriteLine("Email element found.");
            Email_().SendKeys(email_value);
        }

        public void Insert_Password(string password_value)
        {
            Console.WriteLine("Password element found.");
            Password_().SendKeys(password_value);
        }

        public void Click_Login()
        {
            Console.WriteLine("Login button element found.");
            Login_Button().Click();
        }


        public void InsertUsernameAndPass(string username, string pass)
        {
            Insert_Email(username);
            Console.WriteLine("Email inserted");

            Insert_Password(pass);
            Console.WriteLine("Password inserted");

            Click_Login();
            Console.WriteLine("Login button clicked");
        }
    }
}
