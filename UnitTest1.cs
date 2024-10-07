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

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        // Тест на запуск страницы
        [Test]
        [Order(1)]
        public void TestPageLoad()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/kohv/haldusleht.php";

            try
            {
          
                string pageTitle = driver.Title;
                Assert.That(pageTitle.Contains("Kohviautomaat"), "Title does not match.");
            
            }
            catch (Exception ex)
            {
              
                Assert.Fail($"TestPageLoad failed: {ex.Message}");
            }
        }

        // Тест на форму регистрации через модальное окно
        [Test]
        [Order(2)]
        public void TestRegistrationForm()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/kohv/haldusleht.php";

            try
            {
                // Открытие модального окна для регистрации
                IWebElement registerLink = driver.FindElement(By.LinkText("Registreerimine"));
                registerLink.Click();
                Thread.Sleep(1000); 

                // Регистрация 
                IWebElement RegisterElement = driver.FindElement(By.Name("username"));
                RegisterElement.SendKeys("KAKAHA");
                Thread.Sleep(1000);

                IWebElement PasswordElement = driver.FindElement(By.Name("passwd"));
                PasswordElement.SendKeys("KAKAHA.");
                Thread.Sleep(1000);

                IWebElement PasswordAgainElement = driver.FindElement(By.Name("passwd_again"));
                PasswordAgainElement.SendKeys("KAKAHA.");
                Thread.Sleep(1000);


                IWebElement RegisterButton = driver.FindElement(By.Name("registerBtn"));
                RegisterButton.Click();

                Console.WriteLine("Registration form successfully submitted.");
            }
            catch (Exception ex)
            {
             
                Assert.Fail($"Error in registration form: {ex.Message}");
            }
        }

        // Тест на форму музыкального опроса с правильным локатором
       
        [Test]
        [Order(3)]
        public void TestMusicForm()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/index.php?veebileht=musikaankeet/musikaankeet.php";

            try
            {
                // Используем явное ожидание
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                IWebElement nimiElement = wait.Until(drv => drv.FindElement(By.Id("nimi")));
                nimiElement.SendKeys("Oleksandr");
                Thread.Sleep(1000);

                IWebElement dnbRadioButton = driver.FindElement(By.Id("dnb"));
                dnbRadioButton.Click();

                Thread.Sleep(1000);

                IWebElement musicSelectElement = driver.FindElement(By.Id("music"));
                var selectElement = new SelectElement(musicSelectElement);
                selectElement.SelectByText("Tunnis võib kuulata muusikat");
                Thread.Sleep(1000);

                IWebElement jahRadioButton = driver.FindElement(By.Id("jah"));
                jahRadioButton.Click();
                Thread.Sleep(1000);

                IWebElement pointsSlider = driver.FindElement(By.Id("points2"));
                pointsSlider.SendKeys("1");
                Thread.Sleep(1000);

                IWebElement messageElement = driver.FindElement(By.Id("message"));
                messageElement.SendKeys("Ваше сообщение о радио");
                Thread.Sleep(1000);

                IWebElement submitButton = driver.FindElement(By.XPath("//input[@value='OK']"));
                submitButton.Click();

                Console.WriteLine("Music survey form successfully submitted.");
            }
            catch (Exception ex)
            {
              
                Assert.Fail($"Error in music survey form: {ex.Message}");
            }
        }


        // Joulukaar

      
        [Test]
        [Order(4)]
        public void TestJoulupuuButton()
        {
        
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement joulupuuButton = driver.FindElement(By.XPath("//input[@value='Jõulupuu']"));
                joulupuuButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("Jõulupuu button was clicked and canvas interacted.");

            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }

            Thread.Sleep(1000);



        }

        [Test]
        [Order(4)]
        public void TestIncorrectJoulupuuButton()
        {

            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement joulupuuButton = driver.FindElement(By.XPath("//input[@value='Jõulupuu123']"));
                joulupuuButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("Jõulupuu button was clicked and canvas interacted.");

            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }

            Thread.Sleep(1000);



        }

        [Test]
        [Order(5)]
        public void TestPodarokButton()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement podarokButton = driver.FindElement(By.XPath("//input[@value='kingitus']"));
                podarokButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("kingitus button was clicked.");

            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }


            Thread.Sleep(1000);
        }

        [Test]
        [Order(6)]
        public void TestPodarokButton2()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement podarokButton = driver.FindElement(By.XPath("//input[@value='kingitus 2']"));
                podarokButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }

            Thread.Sleep(1000);

        }
    

        [Test]
        [Order(7)]
        public void TestGarlandButton()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement garlandButton = driver.FindElement(By.XPath("//input[@value='Garland']"));
                garlandButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("Garland button was clicked.");
            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }

            Thread.Sleep(1000);


        }

        [Test]
        [Order(8)]
        public void TestTahtButton()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement garlandButton = driver.FindElement(By.XPath("//input[@value='täht']"));
                garlandButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("Täht button was clicked.");
            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }


            Thread.Sleep(1000);

        }

        [Test]
        [Order(8)]
        public void TestKokkuButton()
        {
            driver.Url = "https://oleksandrbohatyrov22.thkit.ee/JSleht/Content/joulukaart/joulukaart.html";

            try
            {
                IWebElement garlandButton = driver.FindElement(By.XPath("//input[@value='Kokku']"));
                garlandButton.Click();


                IWebElement canvasElement = driver.FindElement(By.Id("kanva"));

                TestContext.WriteLine("Kokku button was clicked.");
            }
            catch (Exception ex)
            {

                Assert.Fail($"Error in joulukaart: {ex.Message}");
            }


            Thread.Sleep(1000);

        }

    
        [OneTimeTearDown]
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
