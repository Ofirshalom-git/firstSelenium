using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ColumnsContainer : ComppenantBase
    {
        public IWebElement Columns => Driver.FindElement(By.CssSelector(".columns-container"));

        public ColumnsContainer(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
