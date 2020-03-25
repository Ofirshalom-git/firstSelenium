using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class CatalogRow : ComppenantBase
    {
        public IWebElement RowContent => Driver.FindElement(By.CssSelector(".tab-content"));

        public CatalogRow(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
