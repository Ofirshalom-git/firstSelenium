using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Common;
using FluentAssertions.Primitives;
using FluentAssertions;
using System.Collections.Generic;
//ReferenceTypeAssertions ==> for later assertions

namespace MyStoreAtomation
{
    [TestClass]
    public class CatalogTests : UnitTestBase
    {
        [TestMethod]
        public void AddToCartButtonPopsTest()
        {
            var threwExeption = false;
            try
            {
                var button = CatalogPage.RowContent.Items.HoverOnItemByIndex(0).RowContent.Items.AddToCartButton[0];
            }

            catch
            {
                threwExeption = true;
            }

            threwExeption.Should().BeFalse();
        }
        
        [TestMethod]
        public void AddToCartButtonDisapeersTest()
        {
            var threwExeption = false;
            try
            {
                var button = CatalogPage.RowContent.Items.HoverOnItemByIndex(0).RowContent.Items.AddToCartButton[0];
            }

            catch
            {
                threwExeption = true;
            }

            threwExeption.Should().BeTrue();
        }

        [TestMethod]
        public void AddToCartButtonWorksTest()
        {
            var preAddcartPage = CatalogPage.Header.CartButton.Click<CartPage>();
            var preAddAmount = preAddcartPage.CartTable.GetQuantity();
            var preCatalogPage = preAddcartPage.Header.MyStoreButton.Click<CatalogPage>();
            var postCatalogPage = preCatalogPage.RowContent.Items.HoverOnItemByIndex(0).RowContent.Items.AddToCartButton[0].Click<CatalogPage>();
            var postAddAmount = postCatalogPage.Header.CartButton.Click<CartPage>().CartTable.GetQuantity();
            postAddAmount.Should().Be(preAddAmount+1);
        }

        [TestMethod]
        public void PickedItemColorAppersTest()
        {
            var pressedColor = CatalogPage.RowContent.Items.ItemsOptionalColors[0].Colors[0].ToString();
            CatalogPage.RowContent.Items.ViewItemButton[0].Click<ViewItemPage>().ViewItemRow.PickedColor.ToString().Should().Be(pressedColor);
        }

        [TestMethod]
        public void ColorFilterWorksTest()
        {
            var pickedColor = CatalogPage.RowContent.Filters.ColorFilter[0].ToString();
            var postCatalogPage = CatalogPage.RowContent.Filters.ColorFilter[0].Click<CatalogPage>();
            var selectedColors = new List<string>();
            //foreach() ===> item- open it, check the selected color, add it to the list and close the quick view.
            //then, scan all of the items in the list and make sure they are all equal to the picked color string
            //it can be an assertion
            
            //to shorten
            //foreach(var color in postCatalogPage.RowContent.Items.ItemsPickedColor)
            // add a picked color option by css selector
            
        }

        [TestMethod]
        public void PriceRangeFilterWorksTest()
        {
        }

        [TestMethod]
        public void PriceAndColorFilterWorksTest()
        {
        }

        [TestMethod]
        public void ViewedItemAppersInListTest()
        {
        }

    }
}
