using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;

namespace HotelAdactinWithPOMandExtentReport
{
    [TestClass]
    public class TestExecution : BasePage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            LogReport("TestReport");
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            extentReports.Flush();
        }
        [TestInitialize]
        public void TestInit()
        {
            SeleniumInitialization("Chrome");
            exParentTest = extentReports.CreateTest(TestContext.TestName);
        }
        [TestCleanup]
        public void TestClose()
        {
            SeleniumClose();
        }
        [TestMethod]
        public void AdactinHotel()
        {
            exChildTest = BasePage.exParentTest.CreateNode("Login");
            LoginPage loginPage = new LoginPage();
            loginPage.Login();
            exChildTest = BasePage.exParentTest.CreateNode("Search");
            SearchPage searchPage = new SearchPage();
            searchPage.Search();
            exChildTest = BasePage.exParentTest.CreateNode("Select Hotel");
            SelectHotelPage selectHotelPage = new SelectHotelPage();
            selectHotelPage.SelectHotel();
            exChildTest = BasePage.exParentTest.CreateNode("Book Hotel");
            BookHotelPage bookHotelPage = new BookHotelPage();
            bookHotelPage.BookHotel();
            exChildTest = BasePage.exParentTest.CreateNode("Book Itinerary");
            BookedItineraryPage book = new BookedItineraryPage();
            book.Book();
        }
    }
}
