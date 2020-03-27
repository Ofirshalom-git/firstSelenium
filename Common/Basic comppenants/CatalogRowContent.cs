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
        public List<Item> Items => Driver.FindElements(By.CssSelector(".product_list.grid.row li .product-container")).Select(element => new Item(Driver, element)).ToList();

        public CatalogRowContent(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}

