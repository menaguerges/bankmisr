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
    public class RegistrationPage : Common
    {
        public String UserName;
        public String StaticPassword;
        #region Locators 
        private By FirstName { get => Full(Attribute.id, "customer.firstName"); }

        private By Lastname { get => Full(Attribute.id, "customer.lastName"); }

        private By Address { get => Full(Attribute.id, "customer.address.street"); }

        private By City { get => Full(Attribute.id, "customer.address.city"); }
        private By State { get => Full(Attribute.id, "customer.address.state"); }

        private By Zipcode { get => Full(Attribute.id, "customer.address.zipCode"); }

        private By Mobile{ get => Full(Attribute.id, "customer.phoneNumber"); }
        private By SSN { get => Full(Attribute.id, "customer.ssn"); }

        private By Username { get => Full(Attribute.id, "customer.username"); }
        //  private By IndustrySelected { get => Driver.FindElement(By.XPath("//*[@id="root"]/div/div[3]/div/div/form/div[7]/div[1]/div[2]/div[6]/span"));

        private By Password { get => Full(Attribute.id, "customer.password"); }

        private By Confirmpassword { get => Full(Attribute.id, "repeatedPassword"); }


        private By RegisterButton { get => Full(Attribute.value, "Register"); }
        
        

        #endregion
        public RegistrationPage(IWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
        }

        public string RegisteredEmail;
     


        public void FillRegistrationForm()
        {
            Random Ran = new Random();

            WaitForTextToBeVisible("Signing up is easy");
        
            //Personal Info
            SendKeys(FirstName, "First Name Testing account");
            SendKeys(Lastname, "Last Name Testing account");
            SendKeys(Address, "Address Testing account");
            SendKeys(City, "City Testing account");
            SendKeys(State, "State Testing account");
            SendKeys(Zipcode, "State Testing account");
            SendKeys(Mobile, "Phone Testing account");
            SendKeys(SSN, "SNN Testing account");
            // Credentional 
            SendKeys(Username, "testusername_"+ Ran.Next(1, 10000000)+"_Username");
            SendKeys(Password, "123456");
            SendKeys(Confirmpassword, "123456");



            ClickOn(RegisterButton, false);

            // I tried a lot of combinations for the username and " this username already exists" message always appears
            Assert.IsTrue(Driver.PageSource.Contains("This username already exists."));

           
        }

        
    }
}
     