using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using Shouldly;
using Config;
using BankMisr.Properties;
using System.Globalization;
using BankMisr.Properties;
using BankMisr;

namespace BanqueMisr
{
    [TestFixture]
    public class BankMisrMain : BaseTest
    {
        [Test]


        public void Register_TestCase1()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);
            homePage.GoToRegistrationPage();

            //Fill the registration Form
            RegistrationPage registrationPage = new RegistrationPage(Driver, Wait);
            registrationPage.FillRegistrationForm();



            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }

        [Test]
        public void Login_TestCase2()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);
           

            //Fill Login Form
            Login loginFunction = new Login(Driver, Wait);
            loginFunction.Login_Screen();



            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }



        [Test]
        public void AccountBalance_TestCase3()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);


            //Fill Login Form
            Login loginFunction = new Login(Driver, Wait);
            loginFunction.Login_Screen();

            //Open bank account
            OpenAccount OpenNewAccount = new OpenAccount(Driver, Wait);
            OpenNewAccount.OpenBankAccount();

            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }


        [Test]
        public void TranfserFund_TestCase4()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);


            //Fill Login Form
            Login loginFunction = new Login(Driver, Wait);
            loginFunction.Login_Screen();

            //Open bank account
            TransferFund Tranfser = new TransferFund(Driver, Wait);
            Tranfser.TransferFundFunction();

            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }


        [Test]
        public void RequestLoan_TestCase5()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);


            //Fill Login Form
            Login loginFunction = new Login(Driver, Wait);
            loginFunction.Login_Screen();

            //Request Loan
            RequestLoan loan = new RequestLoan(Driver, Wait);
            loan.RequestloanFunction();

            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }

        [Test]
        public void LogOut_TestCase6()
        {
            // Arrange
            var assertBoolean = true;

            // Act

            //Open the browser and Go to Homepage
            HomePage homePage = new HomePage(Driver, Wait);


            //Fill Login Form
            Login loginFunction = new Login(Driver, Wait);
            loginFunction.Login_Screen();

            loginFunction.LogOut();

            // Assert
            GetBrowserErrors(); // Keep this to capture any errors in browser console before assert

            assertBoolean.ShouldSatisfyAllConditions(
                () => assertBoolean.ShouldBeTrue(),
                () => { if (Settings.FireExceptionOnBrowserConsoleErrors) errors.ShouldBeNullOrEmpty(); });
        }







    }



}