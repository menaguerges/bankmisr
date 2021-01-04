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
    public class OpenAccount : Common
    {
        #region Locators 
        //open account
        private By OpenAccountLink { get => Part(Attribute.href, "openaccount.htm"); }
        private By AccountType { get => Full(Attribute.id, "type"); }
        private By Accounts { get => Full(Attribute.id, "fromAccountId"); }
       
        private By OpenNewAccountButton { get => Full(Attribute.type, "submit"); }

        private By NewAccountID { get => Full(Attribute.id, "newAccountId"); }


        #endregion
        public OpenAccount(IWebDriver driver, WebDriverWait wait)
        {
            
            Driver = driver;
            Wait = wait;
        }

        

        public void OpenBankAccount()
        {
            ClickOn(OpenAccountLink, false);

            //  SelectByIndex(AccountType, 1);

            //  SelectByIndex(Accounts, 5);
            WaitForPageReadyState();
            ClickOn(OpenNewAccountButton,false);
            WaitForPageReadyState();
            Assert.IsTrue(Driver.PageSource.Contains("Congratulations, your account is now open."));
            ClickOn(NewAccountID, false);
        }
    }
}
