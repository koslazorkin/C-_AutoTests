using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFramework;

namespace UITests
{
    [TestClass]
    public class Product_Test
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Init();
        }

        [TestMethod]
        public void BuyTrainers()
        {
            Main_Page.Open();
            Main_Page.Trending("adidas trainers").Open();

            Assert.AreEqual(Main_Page.Page_Title(), "adidas Trainers | CloudFoam, Lite Racer, Duramo | Sports Direct");

            Adidas_Trainers.Open("VL Court 2 Suede Shoes Mens");

            Assert.AreEqual(Adidas_Trainers.Page_Title, "adidas VL Court 2 Suede Shoes | Men's Trainers | Footwear | SportsDirect.com Latvia");
            Assert.AreEqual(Adidas_Trainers.Shoe_Name, "VL Court 2 Suede Shoes Mens");
            Assert.AreEqual(Adidas_Trainers.Shoe_Price, "54,00 €");
            Assert.AreEqual(Adidas_Trainers.Bag_Empty, "BAG IS EMPTY");

            Adidas_Trainers.Select_Size("10 (44.7)");
            Adidas_Trainers.Add_To_Bag();

            Assert.AreEqual(Adidas_Trainers.Bag_Checkout, "CHECKOUT");

            Checkout_Page.Open();

            Assert.AreEqual(Checkout_Page.Product, "adidas VL Court 2 Suede Shoes Mens");
            Assert.AreEqual(Checkout_Page.Size, "Size 10 (44.7)");
            Assert.AreEqual(Checkout_Page.Price, "54,00 €");
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
