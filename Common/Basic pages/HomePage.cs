using OpenQA.Selenium;

namespace Common
{
    public class HomePage : BasePage
    {
        public ColumnsContainer Columns => new ColumnsContainer(Driver, Driver.FindElement(By.CssSelector(".columns-container")));
        public HomePage(IWebDriver driver) : base(driver)
        {

        }
    }
}
