using Clase_1_Automatizacion_27_10_2025.Page;
  

namespace Clase_1_Automatizacion_27_10_2025.Test
{
    public class LoginTest : BaseTest
    {
       
        public void Navegar() { 
        //Aqui van los casos de prueba
         driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login"); //Navega a la URL
        }
        [Test]
        public void LoginExitoso()
        {
            try
            {
                Navegar(); //Llama al metodo navegar para ir a la URL
                LoginPage pom = new LoginPage(driver); //Crea una instancia de la clase LoginPage
                pom.ingresarUsuario("student"); //Ingresa el usuario
                pom.ingresarPassword("Password123"); //Ingresa el password
                pom.clickLogin(); //Hace click en el boton de login
               Assert.That(driver.Url, Is.EqualTo("https://practicetestautomation.com/logged-in-successfully/")); //Verifica que la URL sea la esperada
            }
            catch (Exception ex)
            {
                Assert.Fail("Error inesperado de la prueba, intente de nuevo, error:  " + ex.Message);
            }
        }
    }
}
