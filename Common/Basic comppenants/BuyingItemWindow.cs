using OpenQA.Selenium;

namespace Common
{
    public class BuyingItemWindow : ComppenantBase
    {
        public Button ContinueShoppingButton => new Button(Driver, Driver.FindElement(By.CssSelector("span.continue.btn.btn")));
        public BuyingItemWindow(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public CatalogPage BackToCatalogPage() =>
            ContinueShoppingButton.Click<CatalogPage>();
    }
}
