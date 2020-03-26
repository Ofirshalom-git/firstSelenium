using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ViewItemRow : ComppenantBase
    {
        public IWebElement PickedColor => Driver.FindElement(By.CssSelector(".selected a"));

        public ViewItemRow(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
    }
}
