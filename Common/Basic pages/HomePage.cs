﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class HomePage : BasePage
    {
        public ColumnsContainer Columns => new ColumnsContainer(Driver, Driver.FindElement(By.CssSelector(".columns-container")));
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
    }
}
