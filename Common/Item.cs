using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Item : ComppenantBase
    {
        public Button AddToCartButton => new Button(Driver, Driver.FindElement(By.CssSelector(".product-container .button-container .ajax_add_to_cart_button")));
        public Button ViewButtonOfItem => new Button(Driver, Driver.FindElement(By.CssSelector(".lnk_view.btn.btn-default")));
        public Button QuickViewButton => new Button(Driver, Driver.FindElement(By.CssSelector(".quick-view")));
        public IWebElement ItemPrice => Driver.FindElement(By.CssSelector(".right-block .price.product-price"));
        public ColorRow OptionalColors => new ColorRow(Driver, Driver.FindElement(By.CssSelector(".color_to_pick_list.clearfix")));


        public Item(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public QuickViewPage ClickQuickView(int index) =>
            QuickViewButton.Click<QuickViewPage>();

        public CatalogPage ClickByItemIndex() =>
            AddToCartButton.Click<CatalogPage>();


        public double GetPrice()
        {
            var priceByChars = ItemPrice.ToString().ToCharArray();
            var cleanPrice = new char[priceByChars.Length - 1];
            for (var i = 0; i < cleanPrice.Length; i++)
            {
                cleanPrice[i] = priceByChars[i];
            }

            var cleanPriceString = cleanPrice.ToString();
            return double.Parse(cleanPriceString);
        }

        public CatalogPage HoverOnItemByIndex()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(Driver.FindElement(By.CssSelector("li .product-container")));

            return new CatalogPage(Driver);
        }
    }
}
