using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class ComppenantBase : DriverUser
    {
        protected IWebElement ParentElement { get; private set; }

        public ComppenantBase(IWebDriver driver, IWebElement parentElement) : base(driver)
        {
            ParentElement = parentElement;
        }
    }
}
