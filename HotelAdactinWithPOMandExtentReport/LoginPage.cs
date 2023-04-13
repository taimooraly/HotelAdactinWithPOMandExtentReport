using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Security.Policy;
using System.Threading;

namespace HotelAdactinWithPOMandExtentReport
{
    public class LoginPage : BasePage
    {        
        public void Login()
        {
            OpenUrl(driver, "https://adactinhotelapp.com/index.php");
            Write(driver, By.Id("username"), "AmirImam");
            Write(driver, By.Id("password"), "AmirImam");
            Click(driver, By.Id("login"));
        }
    }
}
