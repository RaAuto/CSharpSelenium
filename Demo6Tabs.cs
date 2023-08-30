using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Demo6Tabs
    {
        public static void Main7(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.db4free.net/";
            driver.FindElement(By.PartialLinkText("phpMyAdmin")).Click();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            driver.FindElement(By.Id("input_password")).SendKeys("Welcome123");
            driver.FindElement(By.Id("input_go")).Click();
           string ErrorMsg= driver.FindElement(By.Id("pma_errors")).Text;
            Console.WriteLine(ErrorMsg);
            driver.Close();
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);
            driver.Quit();


            //click on phpMyAdmin »
        }
    }
}
