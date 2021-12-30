using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LTAPersonalDevProject
{
    class Class1
    {
       // IWebDriver driver = new ChromeDriver();
        [Test]
        public void WebDriverTest()
        {
            IWebDriver driver = new ChromeDriver();
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("Start-Maximized", "-incognito");
            driver.Url = "https://admin-demo.nopcommerce.com/login?";
            driver.Manage().Window.Maximize();


            //driver.FindElement(By.Id("Email")).Clear();
            //driver.FindElement(By.Id("Email")).SendKeys("admin@yourstore.com");
            //driver.FindElement(By.Id("Password")).Clear();
            //driver.FindElement(By.Id("Password")).SendKeys("admin");
            //driver.FindElement(By.ClassName("buttons")).Click();
            //driver.FindElement(By.XPath("//a[@class='nav-link active']")).Click();
            //driver.FindElement(By.XPath("//a[@class='nav-link'][.='Logout']")).Click();


            IWebElement EmailElement = driver.FindElement(By.Id("Email"));
            IWebElement PasswordElement = driver.FindElement(By.Id("Password"));
            Thread.Sleep(3000);
            IWebElement ClickLoginBtn = driver.FindElement(By.ClassName("buttons"));

            Thread.Sleep(3000);
            IList<IWebElement> CatalogElement = driver.FindElements(By.XPath("//p[contains(text(),'Catalog')]"));

            Thread.Sleep(3000);
            IList<IWebElement> ProductElement = driver.FindElements(By.XPath("//p[contains(text(),'Products')]"));
            //IList<IWebElement> ClickCustomerEle = driver.FindElements(By.XPath("//a[@class='nav-link active']"));
            //IWebElement CustomersDetailsElement2 = driver.FindElement(By.LinkText("//a[@href='/Admin/Customer/List']"));
            //IWebElement SearchCustomerViaEmail = driver.FindElement(By.XPath("//*[contains (@class,'col-md-')]/input[@id='SearchEmail']"));
            //IWebElement ClickSearchButton = driver.FindElement(By.XPath("//button[@id='search-customers']"));

            EmailElement.Clear();
            EmailElement.SendKeys("admin@yourstore.com");
            PasswordElement.Clear();
            PasswordElement.SendKeys("admin");
            Thread.Sleep(3000);
            ClickLoginBtn.Click();

            IWebElement ClickDashboardElement = driver.FindElement(By.XPath("//a[@class='nav-link active']"));
            ClickDashboardElement.Click();

            IWebElement ClickLogOutBtn = driver.FindElement(By.XPath("//a[@class='nav-link'][.='Logout']"));
            ClickLogOutBtn.Click();
            Thread.Sleep(2000);

            CatalogElement[0].Click();
            ProductElement[0].Click();

            //ClickCustomerEle[0].Click();
            //CustomersDetailsElement2.Click();
            //SearchCustomerViaEmail.SendKeys("victoria_victoria@nopCommerce.com");
            //ClickSearchButton.Click();

        }
    }
}
