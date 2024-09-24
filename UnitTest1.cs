using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace BohatyrovTEst
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
         
            driver = new ChromeDriver();
        }

        [Test]
        public void TestMainPage()
        {
           
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee";

          
            string mainPageTitle = driver.Title;
            TestContext.Progress.WriteLine("Фактический заголовок главной страницы: " + mainPageTitle);

            string expectedMainTitle = "Oleksandr veebirakenduste leht"; 

            if (mainPageTitle.Contains(expectedMainTitle))
            {
                TestContext.Progress.WriteLine("Успешно открыта главная страница: " + driver.Url);
            }
            else
            {
                Assert.Fail("Открытие главной страницы не удалось. Ожидался заголовок: " + expectedMainTitle + ", но был: " + mainPageTitle);
            }

           
            
        }

        [Test]
        public void NavigateToTood()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/tood.html";


            string toodPageTitle = driver.Title;
            TestContext.Progress.WriteLine("Заголовок страницы tood.html: " + toodPageTitle);

            string expectedToodTitle = "Oleksandr veebirakenduste leht";

            if (toodPageTitle.Contains(expectedToodTitle))
            {
                TestContext.Progress.WriteLine("Успешный переход на страницу: " + driver.Url);
            }
            else
            {
                Assert.Fail("Переход на страницу tood.html не удался. Ожидался заголовок: " + expectedToodTitle + ", но был: " + toodPageTitle);
            }
        }

        [Test]
        public void MenuTest()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/tood.html";


            string toodPageTitle = driver.Title;
            TestContext.Progress.WriteLine("Заголовок страницы tood.html: " + toodPageTitle);

            string expectedToodTitle = "Oleksandr veebirakenduste leht";

            if (toodPageTitle.Contains(expectedToodTitle))
            {
                TestContext.Progress.WriteLine("Успешный переход на страницу: " + driver.Url);
            }
            else
            {
                Assert.Fail("Переход на страницу tood.html не удался. Ожидался заголовок: " + expectedToodTitle + ", но был: " + toodPageTitle);
            }
        }

        [TearDown]
        public void Teardown()
        {
            
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
