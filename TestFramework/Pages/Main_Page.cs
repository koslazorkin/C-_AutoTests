using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Configuration;

namespace TestFramework
{
    public class Main_Page
    {
        public static void Open()
        {            
            Driver.Instance.Navigate().GoToUrl(ConfigurationManager.AppSettings["URL"]);
        }

        public static Trending_Command Trending(string name)
        {
            return new Trending_Command(name);
        }

        public static string Page_Title()
        {
            return Driver.Instance.Title;
        }
    }

    public class Trending_Command
    {
        private string name;

        public Trending_Command(string name)
        {
            this.name = name;
        }

        public void Open()
        {
            //if (existsElement("//*[@id='BodyWrap-Popup']"))
            //{
                Driver.Instance.FindElement(By.XPath("//div[contains(@id, 'advertPopup')]//button[@class = 'close']")).Click();
            //}
            var tranding = Driver.Instance.FindElement(By.XPath("//*[@id='topMenu']/ul/li[1]/a"));
            tranding.Click();

            var adidas_trainers = Driver.Instance.FindElement(By.XPath("//*[@id='topMenu']/ul/li[1]/div/ul/li[3]/ul/li[7]/ul/li[4]/a"));
            adidas_trainers.Click();
        }

        private bool existsElement(String id)
        {
            try
            {
                //var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(5));
                //wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(id)));
                Driver.Instance.FindElement(By.XPath(id));
            }
            catch (NoSuchElementException e)
            {
                return false;
            }
            return true;
        }
    }
}