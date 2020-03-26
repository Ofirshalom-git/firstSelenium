using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class CatalogPage : BasePage
    {
        public CatalogRowContent RowContent => new CatalogRowContent(Driver, Driver.FindElement(By.CssSelector(".tab-content")));

        public CatalogPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
