using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept
{
    public class Assignment1Main
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("john@gmail.com");
            SelectElement selectRole = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectRole.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("ABC");
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("1 - 25 employees");
             driver.FindElement(By.ClassName("checkbox-ui")).Click();
            driver.FindElement(By.Name("start my free trial")).Click();
             string actualError=driver.FindElement(By.XPath("//span[contains(@id,'UserPhone')]")).Text;
            Console.WriteLine(actualError);

            //SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            //selectCountry.SelectByText("United Kingdom");



        }
    }
}
