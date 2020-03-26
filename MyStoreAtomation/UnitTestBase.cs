﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace MyStoreAtomation
{
    [TestClass]
    public class UnitTestBase
    {
        protected HomePage HomePage { get; private set; }
        protected CatalogPage CatalogPage { get; private set; }
        private IWebDriver Driver { get; set; }


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
