using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class CatalogRowContent : ComppenantBase
    {
        public List<Button> AddToCart => Driver.FindElements(By.CssSelector(".product-container .button-container .ajax_add_to_cart_button")).Select(element=> new Button(Driver, element)).ToList();        
        public List<Button> ViewItem => Driver.FindElements(By.CssSelector(".lnk_view.btn.btn-default")).Select(element=> new Button(Driver, element)).ToList();
        public List<IWebElement> Price => Driver.FindElements(By.CssSelector(".right-block .price.product-price")).ToList();
        public List<ColorRow> ColorLists => Driver.FindElements(By.CssSelector(".color_to_pick_list.clearfix")).Select(element => new ColorRow(Driver, element)).ToList();
        public List<Button> ColorFilter => Driver.FindElements(By.CssSelector("#ul_layered_id_attribute_group_3 li")).Select(element => new Button(Driver, element)).ToList();
        public IWebElement PriceRange => Driver.FindElement(By.CssSelector("#layered_price_range"));

        public CatalogRowContent(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public CatalogPage Click(int itemNum) =>
            AddToCart[itemNum].Click<CatalogPage>();

        public double[] GerPriceRange()
        {
            var priceRangeString = PriceRange.ToString();
            var lowestPriceString = new char[4];
            var highestPriceString = new char[4];
            for (var i = 0; i < priceRangeString.Length; i++)
            {
                if (i > 0 && i < 5)
                {
                    lowestPriceString[i] = priceRangeString[i];
                }

                if (i > priceRangeString.Length - 5 && i < priceRangeString.Length)
                {
                    lowestPriceString[i] = priceRangeString[i];
                }
            }

            var lowestPrice = double.Parse(lowestPriceString.ToString());
            var highestPrice = double.Parse(highestPriceString.ToString());
            return new double[2]{lowestPrice, highestPrice};           
        }

        public double GetPrice()
        {
            var priceByChars = Price.ToString().ToCharArray();
            var cleanPrice = new char[priceByChars.Length-1];
            for(var i = 0; i < cleanPrice.Length; i++)
            {
                cleanPrice[i] = priceByChars[i];
            }

            var cleanPriceString = cleanPrice.ToString();
            return double.Parse(cleanPriceString);
        }
    }
}

