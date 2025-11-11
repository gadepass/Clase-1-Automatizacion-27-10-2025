using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1_Automatizacion_27_10_2025.Test
{
    public class BaseTest
    {
        protected IWebDriver driver; //Variable privada que se inicializa en el setup
        [SetUp]
        public void Setup()
        {
            var options = new EdgeOptions(); //Se crea la variable, hace el llamado al driver que se utilizarÃ¡
            driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize(); //Maximiza la ventana del navegador
        }
        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit(); //Quito o cierro el driver.
                driver.Dispose(); // Liberar recursos explÃ­citamente

            }
        }

    }
}
