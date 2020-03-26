using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Common
{
    public class CatalogRowContent : ComppenantBase
    {
        public Filters Filters { get; set; }
        //change to a list of items instead, and by that, change all of the items class
        //dont do it before a non- bugged push!!!!!!!!!!!!!
        public Items Items { get; set; }

        public CatalogRowContent(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}

