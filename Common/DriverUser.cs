using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public abstract class DriverUser
    {
        protected IWebDriver Driver { get; private set; }

        public DriverUser(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
