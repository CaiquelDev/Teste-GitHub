using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = new OpenQA.Selenium.Chrome.ChromeDriver(@"C:\Users\ALUNO\source\repos\Calculadora");

            driver.Navigate().GoToUrl("http://localhost:61393/Calc.aspx");

            int quantidade_test=100;

            for(int i = 0; i < quantidade_test;i++)
            {
                var n1 = new Random(Guid.NewGuid().GetHashCode()).Next(1000);
                var n2 = new Random(Guid.NewGuid().GetHashCode()).Next(1000);

               
                driver.FindElement(By.Id("num1")).SendKeys(n1.ToString());
                driver.FindElement(By.Id("num2")).SendKeys(n2.ToString());
                driver.FindElement(By.Id("soma")).Click();

                var texto = driver.FindElement(By.Id("Result")).Text;
                Assert.IsTrue(Convert.ToDouble(texto) == n1 + n2);
              
                driver.FindElement(By.Id("menos")).Click();
                var texto1 = driver.FindElement(By.Id("Result")).Text;
                Assert.IsTrue(Convert.ToDouble(texto1) == n1 - n2);
                driver.FindElement(By.Id("vezes")).Click();
                var texto2 = driver.FindElement(By.Id("Result")).Text;
                Assert.IsTrue(Convert.ToDouble(texto2) == n1 * n2);
                driver.FindElement(By.Id("divi")).Click();
                var texto3 = driver.FindElement(By.Id("Result")).Text;
                
                Assert.IsTrue(Convert.ToDouble(texto3).ToString("F2") == (Convert.ToDouble(n1)  / Convert.ToDouble(n2)).ToString("F2"));
                driver.FindElement(By.Id("apagar")).Click();
              

            }


        }
    }
}
