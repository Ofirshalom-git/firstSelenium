using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class CartTable : ComppenantBase
    {
        //public IWebElement Table => Driver.FindElement(By.CssSelector("#cart_summary"));

        public List<IWebElement> Garbage => Driver.FindElements(By.CssSelector(".icon-trash")).ToList();
        public List<IWebElement> Price => Driver.FindElements(By.CssSelector(".cart_total .price")).ToList();
        public List<IWebElement> Quantity => Driver.FindElements(By.CssSelector(".cart_quantity.text-center")).ToList();

        public CartTable(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
