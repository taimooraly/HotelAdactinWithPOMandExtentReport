using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace HotelAdactinWithPOMandExtentReport
{    
    public class BookedItineraryPage : BasePage
    {
        public void Book()
        {
            OpenUrl(driver, "https://adactinhotelapp.com/BookedItinerary.php");
            Click(driver, By.Id("check_all"));
            Click(driver, By.Name("cancelall"));
            Thread.Sleep(3000);
            Click(driver, By.Id("logout"));
        }
    }
}
