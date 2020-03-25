using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class HeaderContainer : ComppenantBase
    {
        public Button CartButton => new Button(Driver, Driver.FindElement(By.CssSelector(".shopping_cart a")));
        public Button MyStoreButton => new Button(Driver, Driver.FindElement(By.CssSelector("#header_logo a")));

        public HeaderContainer(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
