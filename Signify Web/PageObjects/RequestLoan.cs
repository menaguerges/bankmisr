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
    public class RequestLoan : Common
    {
        #region Locators 
        //open account
        private By RequestloanLink { get => Part(Attribute.href, "requestloan.htm"); }
        private By Amount { get => Full(Attribute.id, "amount"); }
        private By Downpayment { get => Full(Attribute.id, "downPayment"); }
        

        private By Submit { get => Full(Attribute.type, "submit"); }

   


        #endregion
        public RequestLoan(IWebDriver driver, WebDriverWait wait)
        {
            
            Driver = driver;
            Wait = wait;
        }

        

        public void RequestloanFunction()
        {
            ClickOn(RequestloanLink, false);
            
            SendKeys(Amount, "100");
            SendKeys(Downpayment, "5");


            //  SelectByIndex(Accounts, 5);
            ClickOn(Submit, false);
            WaitForPageReadyState();
            WaitForTextToBeVisible("Approved");
            Assert.IsTrue(Driver.PageSource.Contains("Approved"));
           

           
        }
    }
}
