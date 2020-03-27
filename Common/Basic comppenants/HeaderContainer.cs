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
        public CatalogCategories CatalogCategories => new CatalogCategories(Driver, Driver.FindElement(By.CssSelector("#block_top_menu ul")));
        //public List<Button> CatalogOptions => Driver.FindElements(By.CssSelector("#block_top_menu ul.sf-menu li a.sf-with-ul")).Select(element => new Button(Driver, element)).ToList();

        public HeaderContainer(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

    }
}
