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

        public List<IWebElement> Garbage { get; set; }
        public List<IWebElement> Price { get; set; }
        public List<IWebElement> NumOfItems { get; set; }
        private IWebElement Quantity { get; set; }


        public CartTable(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {
            try
            {
                Garbage = Driver.FindElements(By.CssSelector(".icon-trash")).ToList();
                Price = Driver.FindElements(By.CssSelector(".cart_total .price")).ToList();
                NumOfItems = Driver.FindElements(By.CssSelector(".cart_quantity.text-center")).ToList();
                Quantity = Driver.FindElement(By.CssSelector("#summary_products_quantity"));
            }
            catch
            {
                Quantity = Driver.FindElement(By.CssSelector(".alert.alert-warning"));
            }
        }

        public int GetQuantity()
        {
            if(Quantity.Text == "Your shopping cart is empty.")
            {
                return 0;
            }

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
