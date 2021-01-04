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
    public class TransferFund : Common
    {
        #region Locators 
        //open account
        private By OpenTransferFundLink { get => Part(Attribute.href, "transfer.htm"); }
        private By Amount { get => Full(Attribute.id, "amount"); }
        private By FromAccountID { get => Full(Attribute.id, "fromAccountId"); }
        private By ToAccountID { get => Full(Attribute.id, "toAccountId"); }

        private By TransferButton { get => Full(Attribute.type, "submit"); }

   


        #endregion
        public TransferFund(IWebDriver driver, WebDriverWait wait)
        {
            
            Driver = driver;
            Wait = wait;
        }

        

        public void TransferFundFunction()
        {
            ClickOn(OpenTransferFundLink, false);
            RefreshPage();
            WaitForPageReadyState();
            String Transferedmoney = "1000.00";
           
            String From = FindElement(FromAccountID).GetAttribute("value").ToString();
            String To = FindElement(FromAccountID).GetAttribute("value").ToString();
            do
            {
                RefreshPage();
                WaitForPageReadyState();
                From = FindElement(FromAccountID).GetAttribute("value").ToString();
                To = FindElement(FromAccountID).GetAttribute("value").ToString();
            } 
            while(From == "undefined");
            
            SendKeys(Amount, Transferedmoney);
            //  SelectByIndex(Accounts, 5);
            ClickOn(TransferButton, false);
            WaitForPageReadyState();
            WaitForTextToBeVisible("Transfer Complete!");
            Assert.IsTrue(Driver.PageSource.Contains("has been transferred from account"));
            Assert.IsTrue(Driver.PageSource.Contains(To));
            Assert.IsTrue(Driver.PageSource.Contains(From));

            
        }
    }
}
