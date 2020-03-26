using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class ViewItemPage : BasePage
    {
        public ViewItemRow ViewItemRow => new ViewItemRow(Driver, Driver.FindElement(By.CssSelector("#product #page")));
        
        public ViewItemPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
