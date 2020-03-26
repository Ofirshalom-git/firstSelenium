using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public abstract class BasePage : DriverUser
    {
        protected HeaderContainer Header => new HeaderContainer(Driver, Driver.FindElement(By.CssSelector("#header")));
        protected FooterContainer Footer;

        public BasePage(IWebDriver driver) : base(driver)
        {

        }

        public CatalogPage GoToCatalogPage() =>
            Header.MyStoreButton.Click<CatalogPage>();
        
    }
}
