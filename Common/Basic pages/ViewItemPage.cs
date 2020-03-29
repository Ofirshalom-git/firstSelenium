﻿using OpenQA.Selenium;

namespace Common
{
    public class ViewItemPage : BasePage
    {
        public ViewItemRow ViewItemRow => new ViewItemRow(Driver, Driver.FindElement(By.CssSelector("#product #page")));
        
        public ViewItemPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
