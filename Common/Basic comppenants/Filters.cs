using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Filters : ComppenantBase
    {
        public List<Button> ColorFilter => Driver.FindElements(By.CssSelector("#ul_layered_id_attribute_group_3 li")).Select(element => new Button(Driver, element)).ToList();
        public IWebElement PriceRange => Driver.FindElement(By.CssSelector("#layered_price_range"));


        public Filters(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

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
            return new double[2] { lowestPrice, highestPrice };
        }

    }
}
