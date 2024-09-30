using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
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
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/kohv/haldusleht.php";
        }


        //[Test]
        //public void TestMainPage()
        //{

        //    driver.Url = "https://oleksandrbohatyrov22.thkit.ee";


        //    string mainPageTitle = driver.Title;
        //    TestContext.Progress.WriteLine("Фактический заголовок главной страницы: " + mainPageTitle);

        //    string expectedMainTitle = "Oleksandr veebirakenduste leht"; 

        //    if (mainPageTitle.Contains(expectedMainTitle))
        //    {
        //        TestContext.Progress.WriteLine("Успешно открыта главная страница: " + driver.Url);
        //    }
        //    else
        //    {
        //        Assert.Fail("Открытие главной страницы не удалось. Ожидался заголовок: " + expectedMainTitle + ", но был: " + mainPageTitle);
        //    }



        //}


        [Test]
        public void Kohviautomaat()
        {

            try
            {
                // Появляемся сразу в haldusleht.php
               

              
            }
            catch (Exception ex)
            {

                Assert.Fail("Fail while register form. Error: " + ex.Message);
            }
           

        }
        [Test]
        public void RegistrationForm()
        {
         
            IWebElement eshkereElement = driver.FindElement(By.LinkText("Registreerimine"));


            try
            {
                eshkereElement.Click();
                Thread.Sleep(1000);

            }
            catch (Exception ex)
            {
                Assert.Fail("Fail while register form. Error: " + ex.Message);
            }

            try
            {
                Thread.Sleep(1000);
                IWebElement RegisterElement = driver.FindElement(By.Name("username"));
                RegisterElement.SendKeys("example2");


                Thread.Sleep(1000);
                IWebElement PasswordElement = driver.FindElement(By.Name("passwd"));
                PasswordElement.SendKeys("Cfif2007.");


                Thread.Sleep(1000);
                IWebElement Password_AgainElement = driver.FindElement(By.Name("passwd_again"));
                Password_AgainElement.SendKeys("Cfif2007.");






            }
            catch (Exception ex)
            {
                Assert.Fail("Переход на страницу tood.html не удался. Ошибка: " + ex.Message);
            }

            // konto loomine
            try
            {
                IWebElement KontoLoomine_Element = driver.FindElement(By.Name("registerBtn"));
            }
            catch (Exception ex)
            {

                Assert.Fail("Fail on register. Error: " + ex.Message);
            }





        }





        //[Test]
        public void NavigateToTood()
        {
            // Переход по кнопке Tood
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee";

        
            IWebElement eshkereElement = driver.FindElement(By.LinkText("Tööd"));

            try
            {
                eshkereElement.Click();
                Thread.Sleep(2000);

                string currentUrl = driver.Url;
                string expectedUrl = "https://oleksandrbohatyrov22.thkit.ee/tood.html";

                Console.WriteLine("1) Успешный переход на страницу: " + currentUrl);
                
            }
            catch (Exception ex)
            {
                Assert.Fail("Переход на страницу tood.html не удался. Ошибка: " + ex.Message);
            }

            // Переход на страницу "PHP Tööd"
            try
            {
            
                IWebElement phpToodElement = driver.FindElement(By.LinkText("PHP Tööd"));
                phpToodElement.Click();
                Thread.Sleep(2000);

                // Проверяем текущий URL после перехода
                string currentPhpUrl = driver.Url;
                string expectedPhpUrl = "https://oleksandrbohatyrov22.thkit.ee/JSleht/index.php";

               Console.WriteLine("2) Успешный переход на страницу PHP Tööd: " + currentPhpUrl);
            }
            catch (Exception ex)
            {
                Assert.Fail("Переход на страницу PHP tood не удался. Ошибка: " + ex.Message);
            }

            // Переход на страницу "Musuikaankeet"
            try
            {

                IWebElement phpToodElement = driver.FindElement(By.LinkText("Musikaankeet"));
                phpToodElement.Click();
                Thread.Sleep(2000);

                // Проверяем текущий URL после перехода
                string currentPhpUrl = driver.Url;
     

                Console.WriteLine("3) Успешный переход на страницу Musikaankeet: " + currentPhpUrl);
            }
            catch (Exception ex)
            {
                Assert.Fail("Переход на страницу Musikaankeet не удался. Ошибка: " + ex.Message);
            }


            // Заполнение формы
            try
            {
                Thread.Sleep(1000);
                IWebElement nimiElement = driver.FindElement(By.Id("nimi"));
                nimiElement.SendKeys("Oleksandr"); // Вводим имя

                Thread.Sleep(500);
                IWebElement dnbRadioButton = driver.FindElement(By.Id("dnb"));
                dnbRadioButton.Click(); // Выбираем "Drum and bass"

                Thread.Sleep(500);
                IWebElement musicSelectElement = driver.FindElement(By.Id("music"));
                var selectElement = new SelectElement(musicSelectElement);
                selectElement.SelectByText("Tunnis võib kuulata muusikat"); // Выбор опции

                Thread.Sleep(500);
                IWebElement jahRadioButton = driver.FindElement(By.Id("jah"));
                jahRadioButton.Click(); // Выбор "Да" для ответа на вопрос

                Thread.Sleep(500);
                IWebElement pointsSlider = driver.FindElement(By.Id("points2"));
                pointsSlider.SendKeys("1");


                Thread.Sleep(500);
                IWebElement messageElement = driver.FindElement(By.Id("message"));
                messageElement.SendKeys("Ваше сообщение о радио"); // Вводим сообщение

                Thread.Sleep(500);
                IWebElement beatlesCheckbox = driver.FindElement(By.Id("beatles"));
                if (!beatlesCheckbox.Selected)
                {
                    beatlesCheckbox.Click(); 
                }

                IWebElement michaelCheckbox = driver.FindElement(By.Id("Micheal"));
                if (!michaelCheckbox.Selected)
                {
                    michaelCheckbox.Click(); 
                }


                IWebElement centCheckbox = driver.FindElement(By.Id("cent"));
                if (!centCheckbox.Selected)
                {
                    centCheckbox.Click();
                }
                Thread.Sleep(500);


                IWebElement kontsertElement = driver.FindElement(By.Id("kontsert"));
                kontsertElement.SendKeys("ssshhhiiittt");


                Thread.Sleep(500);
                IWebElement musikElement = driver.FindElement(By.Id("musik"));
                musikElement.SendKeys("вышел покурить");

                Thread.Sleep(500);
                IWebElement submitButton = driver.FindElement(By.XPath("//input[@value='OK']"));
                submitButton.Click();

                Console.WriteLine("Форма успешно заполнена и отправлена.");
            }
            catch (Exception ex)
            {
                Assert.Fail("Заполнение формы на странице Musikaankeet не удалась. Ошибка: " + ex.Message);
            }

        }



        [TearDown]
        public void Teardown()
        {
            
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
