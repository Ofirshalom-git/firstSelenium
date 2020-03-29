using OpenQA.Selenium;

namespace Common
{
    public class CartPage : BasePage
    {
        public CartTable CartTable => new CartTable(Driver, Driver.FindElement(By.CssSelector("#center_column")));

        public CartPage(IWebDriver driver) : base(driver)
        {

        }
    }
}
