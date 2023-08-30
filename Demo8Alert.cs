using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Demo8Alert
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();
            string alertbox=driver.SwitchTo().Alert().Text;
            Console.WriteLine(alertbox);
            driver.SwitchTo().Alert().Accept();



        }
    }
}
