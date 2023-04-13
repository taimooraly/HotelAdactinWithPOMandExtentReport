using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace HotelAdactinWithPOMandExtentReport
{    
    public class BookHotelPage : BasePage
    {
        public void BookHotel()
        {
            Write(driver, By.Id("first_name"), "Syed Taimoor");
            Write(driver, By.Id("last_name"), "Ali");
            Write(driver, By.Id("address"), "Karachi, Pakistan");
            Write(driver, By.Id("cc_num"), "5590524126324522");
            Write(driver, By.Id("cc_type"), "Master Card");
            Write(driver, By.Id("cc_exp_month"), "August");
            Write(driver, By.Id("cc_exp_year"), "2022");
            Write(driver, By.Id("cc_cvv"), "542");
            Thread.Sleep(5000);
            Click(driver, By.Id("book_now"));            
        }
    }
}
