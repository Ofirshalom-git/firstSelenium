using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class RowContent : ComppenantBase
    {
        public List<Button> AddToCart => Driver.FindElements(By.CssSelector("#homefeatured .button-container .ajax_add_to_cart_button")).Select(element=> new Button(Driver, element)).ToList();
        public List<Button> ViewItem => Driver.FindElements(By.CssSelector("#homefeatured .icon-eye-open")).Select(element=> new Button(Driver, element)).ToList();
        public List<IWebElement> Price => Driver.FindElements(By.CssSelector("#homefeatured .right-block .price.product-price")).ToList();

        public RowContent(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        //change to specific page 
        public BasePage Click(int itemNum) =>
            AddToCart[itemNum].Click<BasePage>();
        
    }
}

