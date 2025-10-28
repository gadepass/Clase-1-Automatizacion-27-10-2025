using OpenQA.Selenium;
using OpenQA.Selenium.Edge;

namespace Clase_1_Automatizacion_27_10_2025
{
    public class Tests
    {
        private IWebDriver driver; //Variable privada que se inicializa en el setup

        [SetUp]
        public void Setup()
        {
            var options = new EdgeOptions(); //Se crea la variable, hace el llamado al driver que se utilizará
            driver = new EdgeDriver(options);
        }

        [Test] //Los Test o el etiquetado de test siempre deben estar.
        public void TestNavegar()
        {
            driver.Navigate().GoToUrl("https://www.bing.com"); //Siempre lleva punto y coma                                                  
            driver.Manage().Window.Maximize(); //para maximizar la ventana del navegador.
            // Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit(); //Quito o cierro el driver.
        }
    }
}