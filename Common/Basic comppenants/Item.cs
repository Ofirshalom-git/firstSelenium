using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Common
{
    public class Item : ComppenantBase
    {
        public IWebElement Name => Driver.FindElement(By.CssSelector(".right-block a.product-name"));
        public Button AddToCartButton => new Button(Driver, Driver.FindElement(By.CssSelector(".product-container .button-container .ajax_add_to_cart_button")));
        public Button ViewButton => new Button(Driver, Driver.FindElement(By.CssSelector(".lnk_view.btn.btn-default")));
        public Button QuickViewButton => new Button(Driver, Driver.FindElement(By.CssSelector(".quick-view")));
        public IWebElement Price => Driver.FindElement(By.CssSelector(".right-block .price.product-price"));
        public ColorRow OptionalColors => new ColorRow(Driver, Driver.FindElement(By.CssSelector(".color_to_pick_list.clearfix")));


        public Item(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public QuickViewWindow ClickQuickView() =>
            QuickViewButton.Click<QuickViewWindow>();

        public CatalogPage ClickByItemIndex() =>
            AddToCartButton.Click<CatalogPage>();

        public BuyingItemWindow ClickAddToCart() =>
            AddToCartButton.Click<BuyingItemWindow>();

        public double GetPrice()
        {
            var priceByChars = Price.ToString().ToCharArray();
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
