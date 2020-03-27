using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CatalogCategories : ComppenantBase
    {
        public Button Women => Driver.FindElements(By.CssSelector("#block_top_menu ul.sf-menu li a.sf-with-ul")).Select(element => new Button(Driver, element)).ToList()[0];
        //public Button Women => Driver.FindElements(By.CssSelector("#block_top_menu ul.sf-menu li a.sf-with-ul")).Select(element => new Button(Driver, element)).FirstOrDefault(element => element.ToString().ToLower() == "women");
        public Button Dresses => Driver.FindElements(By.CssSelector("#block_top_menu ul.sf-menu li a.sf-with-ul")).Select(element => new Button(Driver, element)).FirstOrDefault(element => element.ToString().ToLower() == "dresses");
        public Button TShirts => Driver.FindElements(By.CssSelector("#block_top_menu ul.sf-menu li a.sf-with-ul")).Select(element => new Button(Driver, element)).FirstOrDefault(element => element.ToString().ToLower() == "t-shirts");

        public CatalogCategories(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }
       
        public CatalogPage ClickOnWomenCategory() =>
            Women.Click<CatalogPage>();
        public CatalogPage ClickOnDressesCategory() =>
            Dresses.Click<CatalogPage>();
        public CatalogPage ClickOnTShirtsCategory() =>
            TShirts.Click<CatalogPage>();

    }
}
