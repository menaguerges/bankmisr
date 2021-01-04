using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using BanqueMisr;

namespace BankMisr.Properties
{
    public class Login : Common
    {
        #region Locators 
        //Login form
        private By Container1 { get => Full(Attribute.id, "mainPanel"); }
        private By Container2 { get => Full(Attribute.id, "bodyPanel"); }
        private By Container3 { get => Full(Attribute.id, "leftPanel"); }
        private By Container4 { get => Full(Attribute.id, "loginPanel"); }
        private By Username { get => Full(Attribute.name, "username"); }
        private By password { get => Full(Attribute.name, "password"); }
       
        private By LoginButton { get => Full(Attribute.value, "Log In"); }
        private By LogoutButton { get => Part(Attribute.href, "logout.htm"); }

        #endregion
        public Login(IWebDriver driver, WebDriverWait wait)
        {
            
            Driver = driver;
            Wait = wait;
        }

        

        public void Login_Screen()
        {
            
            SendKeys(Username, Settings.AccountUsername);
           
            SendKeys(password, Settings.AccountPassword);
            
            ClickOn(LoginButton,false);
            // I can't register so i enter any username and password and assert that the below text is appeared
            Assert.IsTrue(Driver.PageSource.Contains("Accounts Overview"));

            
            
            
        }
        public void LogOut()
        {
            ClickOn(LogoutButton, false);
            Assert.IsTrue(FindElement(LoginButton).Displayed);

        }

    }
}
