using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using AventStack.ExtentReports.Reporter.Configuration;
using AventStack.ExtentReports.Reporter;

namespace HotelAdactinWithPOMandExtentReport
{
    public class BasePage
    {
        public static IWebDriver driver;
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;
        public static void SeleniumInitialization(string browser)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"..\..\TestExecutionReports\" + '_' + testcase;

            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);

            htmlReporter.Config.Theme = Theme.Standard;

            extentReports.AttachReporter(htmlReporter);
        }        
        public static void SeleniumClose()
        {
            driver.Close();
        }
        public static void TakeScreenshot(Status status, string stepDetail)
        {
            string path = @"C:\TestExecutionReports\" + "TestExecLog_" + DateTime.Now.ToString("yyyyMMddHHmmss");
            Screenshot image_username = ((ITakesScreenshot)driver).GetScreenshot();
            image_username.SaveAsFile(path + ".png", ScreenshotImageFormat.Png);
            BasePage.exChildTest.Log(status, stepDetail, MediaEntityBuilder.CreateScreenCaptureFromPath(path + ".png").Build());
        }
        public void Write(IWebDriver driver, By by, string data)
        {
            driver.FindElement(by).SendKeys(data);
        }
        public void Click(IWebDriver driver, By by)
        {
            driver.FindElement(by).Click();
        }
        public void Clear(IWebDriver driver, By by)
        {
            driver.FindElement(by).Clear();
        }
        public void OpenUrl(IWebDriver driver, string url)
        {           
                driver.Url = url;              
        }
    }
}
