using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTAPersonalDevProject
{
    class Class1
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        public void WebDriverTest()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("Start-Maximized", "-incognito");
            driver.Url = "https://admin-demo.nopcommerce.com/login?";
            driver.Manage().Window.Maximize();

            
            //driver.FindElement(By.Id("Email")).Clear(); 
            //driver.FindElement(By.Id("Email")).SendKeys("admin@yourstore.com");
            //driver.FindElement(By.Id("Password")).Clear();
            //driver.FindElement(By.Id("")).SendKeys("admin"); 
            //driver.FindElement(By.ClassName("buttons")).Click();


            IWebElement EmailElement = driver.FindElement(By.Id("Email"));
            IWebElement PasswordElement = driver.FindElement(By.Id("Password"));
            IWebElement SubmitButtonElement = driver.FindElement(By.XPath("//*[@type='submit']"));
            IWebElement CatalogElement = driver.FindElement(By.XPath("//p[contains(text(),'Catalog')]"));
            IWebElement ProductElement = driver.FindElement(By.XPath("//p[contains(text(),'Products')]"));

            EmailElement.Clear();  
            EmailElement.SendKeys("admin@yourstore.com");

            PasswordElement.Clear();
            PasswordElement.SendKeys("admin");

            SubmitButtonElement.Click();

            CatalogElement.Click();
            ProductElement.Click(); 


        }
    }
}
