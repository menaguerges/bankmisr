using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanqueMisr;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BankMisr.Properties
{
    public class HomePage : Common
    {
        public HomePage(IWebDriver driver, WebDriverWait wait)
        {
            Driver = driver;
            Wait = wait;
            GoToUrl(Settings.Frontend_URL);
            WaitForPageReadyState();
        }

        #region By Locators
     //private  By regLink = By.CssSelector("[src='demo/images/multi.jpg']");

     private By regLink { get => Part(Attribute.href, "register.htm"); }

        

       
        #endregion

        public RegistrationPage GoToRegistrationPage()
        {
            WaitFor(regLink, Condition.Exist, "Registration Link");
          
            ClickOn(regLink, false, "Registration Link");
            
            return new RegistrationPage (Driver, Wait);
        }
    }
}
