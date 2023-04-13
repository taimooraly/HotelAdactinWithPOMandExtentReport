using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace HotelAdactinWithPOMandExtentReport
{
    public class SearchPage : BasePage
    {
        public void Search()
        {            
            Write(driver, By.Id("location"), "Sydney");
            Write(driver, By.Id("hotels"), "Hotel Creek");
            Write(driver, By.Id("room_type"), "Double");
            Write(driver, By.Id("room_nos"), "2 - Two");
            Write(driver, By.Id("datepick_in"), "27/03/2023");
            Write(driver, By.Id("datepick_out"), "28/03/2023");
            Write(driver, By.Id("adult_room"), "2 - Two");
            Write(driver, By.Id("child_room"), "2 - Two");
            Click(driver, By.Id("Submit"));
        }
    }
}
