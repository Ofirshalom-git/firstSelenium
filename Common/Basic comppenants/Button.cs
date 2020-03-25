using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class Button : ComppenantBase
    {
        public Button(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public T Click<T>()
        {
            ParentElement.Click();
            return (T)Activator.CreateInstance(typeof(T), Driver);
        }
    }
}
