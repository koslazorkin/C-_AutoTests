using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestFramework
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }
        public static void Init()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Instance.Manage().Window.Maximize();
        }

        public static void Close()
        {
            Instance.Close();
        }

        public static void Quit()
        {
            Instance.Quit();
        }
    }
}