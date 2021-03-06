﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Common
{
    public class Quantity : ComppenantBase
    {
        public IWebElement QuantityIncrease => Driver.FindElement(By.CssSelector(".cart_quantity.text-center"));
        public IWebElement QuantityDecrease => Driver.FindElement(By.CssSelector(".cart_quantity.text-center"));
        public IWebElement QuantityByNumber => Driver.FindElement(By.CssSelector(".cart_quantity.text-center"));

        public Quantity(IWebDriver driver, IWebElement parentElement) : base(driver, parentElement)
        {

        }

        public void IncreaseQuantityBy(int units)
        {
            MultiplyClick(QuantityIncrease, units);
        }

        public void DecreaseQuantityBy(int units)
        {
            MultiplyClick(QuantityDecrease, units);
        }

        public void ChangeQuantity(double units)
        {
            QuantityByNumber.Clear();
            QuantityByNumber.SendKeys(units.ToString());
        }

        private void MultiplyClick(IWebElement element, int count)
        {
            for (var i = 0; i < count; i++)
            {
                element.Click();
            }
        }
    }
}
