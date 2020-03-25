using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CartPage : BasePage
    {
        public CartTable CartTable => new CartTable(Driver, Driver.FindElement(By.CssSelector("#cart_summary")));

        public CartPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
