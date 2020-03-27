﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class BuyingItemWindow : ComppenantBase
    {
        public Button ContinueShoppingButton => new Button(Driver, Driver.FindElement(By.CssSelector("span.continue.btn.btn")));
        public BuyingItemWindow(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public CatalogPage BackToCatalogPage() =>
            ContinueShoppingButton.Click<CatalogPage>();
    }
}
