using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1_Automatizacion_27_10_2025.Page
{
    
    public class BasePage
    {
        private IWebDriver driver;
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ingresarTbx(By selector, string texto)
        {
            driver.FindElement(selector).SendKeys(texto);

        }
        public void clickBtn(By selector)
        {
            driver.FindElement(selector).Click();
     
        }

        public string obtenerTexto(By selector)
        {
            return driver.FindElement(selector).Text;
        }
    }
}
