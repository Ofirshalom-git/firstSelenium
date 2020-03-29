﻿using OpenQA.Selenium;

namespace Common
{
    public class QuickViewWindow : ComppenantBase
    {
        public Button CloseButton => new Button(Driver, Driver.FindElement(By.CssSelector("a.fancybox-item.fancybox-close")));
        public IWebElement PickedColor => Driver.FindElement(By.CssSelector("#color_to_pick_list .selected a"));

        public QuickViewWindow(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
