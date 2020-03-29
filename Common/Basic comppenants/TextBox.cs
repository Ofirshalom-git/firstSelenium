﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TextBox : ComppenantBase
    {
        public TextBox(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public void Fill(string text) =>        
            ParentElement.SendKeys(text);                    
    }
}
