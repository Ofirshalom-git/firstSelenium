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
                //hover over item[0], try to access it's addToCart button, if it won't apper it will throw an exception.
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
                //hover over item[0], try to access it's addToCart button, if it won't apper it will throw an exception.
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
            //click on cart button to count items
            var preAddcartPage = CatalogPage.Header.CartButton.Click<CartPage>();
            var preAddAmount = preAddcartPage.CartTable.GetQuantity();
            //go to myStore
            var preCatalogPage = preAddcartPage.Header.MyStoreButton.Click<CatalogPage>();
            //add the Item[0] to cart
            var postCatalogPage = preCatalogPage.RowContent.Items.HoverOnItemByIndex(0).RowContent.Items.AddToCartButton[0].Click<CatalogPage>();
            //go to cart and count items
            var postAddAmount = postCatalogPage.Header.CartButton.Click<CartPage>().CartTable.GetQuantity();
            //num of items should be 1 more
            postAddAmount.Should().Be(preAddAmount+1);
        }

        [TestMethod]
        public void PickedItemColorAppersTest()
        {
            //save color's name by going to color filter and check what color by it's index 
            var pressedColor = CatalogPage.RowContent.Items.OptionalColorsOfItem[0].Colors[0].ToString();
            //click on this color
            CatalogPage.RowContent.Items.OptionalColorsOfItem[0].Colors[0].Click<CatalogPage>();
            //the picked color should be the same
            CatalogPage.RowContent.Items.ViewButtonOfItem[0].Click<ViewItemPage>().ViewItemRow.PickedColor.ToString().Should().Be(pressedColor);
        }

        [TestMethod]
        public void ColorFilterWorksTest()
        {
            //go to color filter & save the color's name by it's index
            var pickedColor = CatalogPage.RowContent.Filters.ColorFilter[0].ToString();
            //click on the color and save the page to use it
            var postCatalogPage = CatalogPage.RowContent.Filters.ColorFilter[0].Click<CatalogPage>();
            //            var selectedColors = new List<string>();
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
