using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class CartTable : ComppenantBase
    {
        //public IWebElement Table => Driver.FindElement(By.CssSelector("#cart_summary"));

        public List<IWebElement> Garbage => Driver.FindElements(By.CssSelector(".icon-trash")).ToList();
        public List<IWebElement> Price => Driver.FindElements(By.CssSelector(".cart_total .price")).ToList();
        public List<IWebElement> NumOfItems => Driver.FindElements(By.CssSelector(".cart_quantity.text-center")).ToList();
        private IWebElement Quantity => Driver.FindElement(By.CssSelector("#summary_products_quantity"));

        public CartTable(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public int GetQuantity()
        {
            var cleanNumOfProducts = new List<char>();
            var numOfProductsString = Quantity.ToString().ToCharArray();
            for(var i = 0; i < numOfProductsString.Length; i++)
            {
                if(numOfProductsString[i].ToString() == " ")
                {
                    break;
                }

                cleanNumOfProducts.Add(numOfProductsString[i]);
            }

            var numOfProducts = int.Parse(cleanNumOfProducts.ToArray().ToString());

            return numOfProducts;
        }
    }
}
