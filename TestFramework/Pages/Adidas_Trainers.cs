using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public class Adidas_Trainers
    {
        public static string Page_Title
        {
            get
            {                
                var title = Driver.Instance.Title;
                return title;
            }
        }

        public static string Shoe_Name
        {
            get
            {
                var shoe_name = Driver.Instance.FindElement(By.Id("lblProductName"));                
                return shoe_name.Text;
            }
        }

        public static string Shoe_Price
        {
            get
            {
                var shoe_price = Driver.Instance.FindElement(By.ClassName("productHasRef"));
                return shoe_price.Text;
            }
        }


        public static string Bag_Empty
        {
            get
            {
                var bag_status = Driver.Instance.FindElement(By.ClassName("HeaderBagEmptyMessage"));
                return bag_status.Text;
            }
        }

        public static string Bag_Checkout
        {
            get
            {
                Wait.UntilVisible(By.ClassName("HeaderCheckoutLink"), Driver.Instance, 10000);
                var bag_status = Driver.Instance.FindElement(By.ClassName("HeaderCheckoutLink"));
                return bag_status.Text;
            }
        }

        public static void Add_To_Bag()
        {
            var add_to_bag = Driver.Instance.FindElement(By.ClassName("addToBag"));
            add_to_bag.Click();
        }

        public static void Select_Size(string size)
        {
            var shoe_size = Driver.Instance.FindElement(By.XPath("//div[@id = 'productVariantAndPrice']//a[contains(text(), '"+size+"')]"));
            shoe_size.Click();
        }

        public static void Open(string name)
        {
            var product = Driver.Instance.FindElement(By.PartialLinkText(name));
            product.Click();
        }
    }
}
