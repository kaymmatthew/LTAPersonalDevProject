using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace LTAPersonalDevProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //Assert.Pass();
            //System.Console.WriteLine("Hellow World");

            //var B = 5 + 5 * 10;

            //System.Console.WriteLine(B);

            int a = 100;
            int e = 200;
            System.Console.WriteLine(a / e);

            string myName = "Kayode Matthew";
            System.Console.WriteLine(myName); 



        }

        //[TearDown]
        //public void QuitBrowser()
        //{
           
        //}
    }
}