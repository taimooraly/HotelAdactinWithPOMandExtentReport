using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace HotelAdactinWithPOMandExtentReport
{
    public class SelectHotelPage : BasePage
    {
        public void SelectHotel()
        {
            Click(driver, By.Id("radiobutton_0"));            
            Click(driver, By.Id("continue"));
        }
    }
}
