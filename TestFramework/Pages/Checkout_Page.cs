using System;
using OpenQA.Selenium;

namespace TestFramework
{
    public class Checkout_Page
    {
        
        public static void Open()
        {
            var bag_status = Driver.Instance.FindElement(By.ClassName("HeaderCheckoutLink"));
            bag_status.Click();
        }

        public static string Product
        {
            get
            {
                var product_title = Driver.Instance.FindElement(By.ClassName("productTitle"));
                return product_title.Text;
            }
        }

        public static string Size
        {
            get
            {
                var size = Driver.Instance.FindElement(By.XPath("//table//div[contains(@class, 'size')]"));
                return size.Text;
            }
        }
        public static string Price
        {
            get
            {
                var price = Driver.Instance.FindElement(By.XPath("//td[@class = 'itemprice']//span[@class = 'money']"));
                return price.Text;
            }
        }
    }
}
