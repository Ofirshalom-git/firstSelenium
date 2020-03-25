using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace MyStoreAtomation
{
    [TestClass]
    public class UnitTestBase
    {
        protected HomePage HomePage;
        protected CatalogPage CatalogPage;

        private IWebDriver Driver;


        [TestInitialize]
        public void Initializer()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            HomePage = new HomePage(Driver);
            CatalogPage = HomePage.GoToCatalogPage();
        }

        [TestCleanup]
        public void Clean()
        {
            Driver.Close();
        }
    }
}
