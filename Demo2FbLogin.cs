using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class Demo2FbLogin
    {

        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Id("email")).SendKeys("ranjithn06@gmail.com");
            driver.FindElement(By.Id("pass")).SendKeys("abc");
            driver.FindElement(By.Name("login")).Click();
           

           
        }
    }
}
