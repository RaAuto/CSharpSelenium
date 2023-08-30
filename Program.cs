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
    public class Program
    {
      
            public static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com/gmail/about/";

            String actualTitle = driver.Title;
            // Console.WriteLine(actualTitle);

        }
    }
}
