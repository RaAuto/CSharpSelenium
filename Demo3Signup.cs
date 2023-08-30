using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept
{
    public class Demo3Signup
    {
        public static void Main9(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.LinkText("Create new account")).Click();
            //driver.FindElement(By.Id("pass")).SendKeys("abc");
            //Thread.Sleep(2000);
            driver.FindElement(By.Name("firstname")).SendKeys("Ranjith");
            driver.FindElement(By.Name("lastname")).SendKeys("N");
            driver.FindElement(By.Name("reg_email__")).SendKeys("ranjithkee@gmail.com");
            driver.FindElement(By.Name("reg_email_confirmation__")).SendKeys("ranjithkee@gmail.com");
            driver.FindElement(By.Id("password_step_input")).SendKeys("ABC");
            SelectElement selectDay =new SelectElement(driver.FindElement(By.Id("day")));
            selectDay.SelectByValue("31");
            SelectElement selectMonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectMonth.SelectByText("Sep");
            SelectElement selectYear = new SelectElement(driver.FindElement(By.Id("year")));
            selectYear.SelectByValue("2022");
            driver.FindElement(By.XPath("//input[@value='2']")).Click();
            driver.FindElement(By.Name("websubmit")).Click();
            


        }
    }
}
