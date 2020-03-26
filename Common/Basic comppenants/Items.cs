using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Items : ComppenantBase
    {

        public List<Button> AddToCartButton => Driver.FindElements(By.CssSelector(".product-container .button-container .ajax_add_to_cart_button")).Select(element => new Button(Driver, element)).ToList();
        public List<Button> ViewItemButton => Driver.FindElements(By.CssSelector(".lnk_view.btn.btn-default")).Select(element => new Button(Driver, element)).ToList();
        public List<Button> QuickViewButton => Driver.FindElements(By.CssSelector(".quick-view")).Select(element => new Button(Driver, element)).ToList();
        public List<IWebElement> ItemsPrices => Driver.FindElements(By.CssSelector(".right-block .price.product-price")).ToList();
        //change it's Css Selector to the right one 
        public List<IWebElement> ItemsPickedColor => Driver.FindElements(By.CssSelector(".right-block .price.product-price")).ToList();
        public List<ColorRow> ItemsOptionalColors => Driver.FindElements(By.CssSelector(".color_to_pick_list.clearfix")).Select(element => new ColorRow(Driver, element)).ToList();

        public Items(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public QuickViewPage ClickQuickView(int index) =>
            QuickViewButton[index].Click<QuickViewPage>();
        
        public CatalogPage ClickByItemIndex(int itemNum) =>
            AddToCartButton[itemNum].Click<CatalogPage>();


        public double GetPrice()
        {
            var priceByChars = ItemsPrices.ToString().ToCharArray();
            var cleanPrice = new char[priceByChars.Length - 1];
            for (var i = 0; i < cleanPrice.Length; i++)
            {
                cleanPrice[i] = priceByChars[i];
            }

            var cleanPriceString = cleanPrice.ToString();
            return double.Parse(cleanPriceString);
        }

        public CatalogPage HoverOnItemByIndex(int index)
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(Driver.FindElements(By.CssSelector("li .product-container")).ToList()[index]);

            return new CatalogPage(Driver);
        }
    }
}
