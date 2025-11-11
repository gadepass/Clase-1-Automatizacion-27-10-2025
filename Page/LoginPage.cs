using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1_Automatizacion_27_10_2025.Page
{
    public class LoginPage : BasePage
    {
        
        private By usernameInput = By.Id("username");//hace referencia al selector de username
        private By passwordInput = By.Id("password"); //hace referencia al selector de password
        private By loginButton = By.Id("submit"); //hace referencia al selector del boton de login

        private By MsgLoginExitoso = By.CssSelector("p[class='has-text-align-center'] strong"); //hace referencia al selector del mensaje de login exitoso
        private By MsgLoginFallido = By.CssSelector("#error"); //hace referencia al selector del mensaje de login fallido
     

        public LoginPage(IWebDriver driver): base(driver) { }


        public void ingresarUsuario(string username)
        {
            ingresarTbx(usernameInput, username); //Utiliza metodo de la clase base para ingresar el usuario
        }

        public void ingresarPassword(string password)
        {
            ingresarTbx(passwordInput, password); //Utiliza metodo de la clase base para ingresar el password

        }

        public void clickLogin()
        {
            clickBtn(loginButton);
           
        } 

        public string obtenerMensajeLoginExitoso()
        {
           return obtenerTexto(MsgLoginExitoso); //Utiliza metodo de la clase base para obtener el texto del mensaje de login exitoso
        }

        public string obtenerMensajeLoginFallido()
        {
            return obtenerTexto(MsgLoginFallido); //Utiliza metodo de la clase base para obtener el texto del mensaje de login fallido
        }

        public void login (string username, string password)
        {
            ingresarUsuario(username);
            ingresarPassword(password);
            clickLogin();
        }

    }
}
