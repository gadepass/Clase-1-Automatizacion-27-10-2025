using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;

namespace Clase_1_Automatizacion_27_10_2025
{
    public class Tests
    {

    

        //private IWebDriver driver; //Variable privada que se inicializa en el setup

        //[SetUp]
        //public void Setup()
        //{

        //    var options = new EdgeOptions(); //Se crea la variable, hace el llamado al driver que se utilizará
        //    driver = new EdgeDriver(options);
        //}

        //[Test] //Los Test o el etiquetado de test siempre deben estar.
        //[Category("Bing")] //Categoría del test
        //[Ignore("Ignorando este test por X")] //Ignorar el test con una razón
        //public void TestNavegar()
        //{
        //    driver.Navigate().GoToUrl("https://www.bing.com"); //Siempre lleva punto y coma                                                  
        //    driver.Manage().Window.Maximize(); //para maximizar la ventana del navegador.
        //    //IWebElement elemento = new driver.WebElement();

        //    // Assert.Pass();
        //}

        //[Test]
        //public void loginExitoso()
        //{
        //    driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/"); //Para ingresar a la página
        //    driver.FindElement(By.Id("username")).SendKeys("student"); //Para ingresar el usuario, el usuario es student
        //    driver.FindElement(By.CssSelector("#password")).SendKeys("Password123"); //Para ingresar la contraseña, la contraseña es Password123
        //    driver.FindElement(By.Id("submit")).Click(); //Para hacer click en el botón de submit e ingresar a la sesión.
        //    Thread.Sleep(2000); //Espera de 6 segundos para que cargue la página.
        //    Assert.That(driver.FindElement(By.XPath("//h1[normalize-space()='Logged In Successfully']")).Displayed, Is.True); //Validar que el mensaje de "Logged In Successfully" esté visible y se reafirma que sea TRUE.
        //    //Los asserts siempre van al final del test, se usan para validar que lo que se espera sea igual a lo que realmente sucede.

        //}
        //[TestCase("student", "Password123", true)]
        //[TestCase("student", "Password1234", false)] //Para que cuando haga la compración del assert pase  bien
        //[TestCase("student2", "Password123", false)]//Para que cuando haga la compración del assert pase  bien
        //public void loginExitosoConTestCase(string usuario, string contrasena, bool resultadoEsperado)
        //{
        //    driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/"); //Para ingresar a la página
        //    driver.FindElement(By.Id("username")).SendKeys(usuario); //Para ingresar el usuario, el usuario es student
        //    driver.FindElement(By.CssSelector("#password")).SendKeys(contrasena); //Para ingresar la contraseña, la contraseña es Password123
        //    driver.FindElement(By.Id("submit")).Click(); //Para hacer click en el botón de submit e ingresar a la sesión.
        //    Thread.Sleep(2000); //Espera de 2 segundos para que cargue la página.
            
        //    bool loginExitoso = driver.PageSource.Contains("Logged In Successfully"); //Verifica si el texto "Logged In Successfully" está presente en la página.
        //    if (loginExitoso)
        //    {
        //        Console.WriteLine("El login fue exitoso.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("El login falló: Usuario o contraseña incorrectos.");
        //    }
        //    Assert.That(loginExitoso, Is.EqualTo(resultadoEsperado)); //Compara el resultado del login con el resultado esperado.
        //    //Los asserts siempre van al final del test, se usan para validar que lo que se espera sea igual a lo que realmente sucede.
        //}

        //[Test]
        //public void interactuarCheckBox()
        //{ 
        //    driver.Navigate().GoToUrl("https://demoqa.com/checkbox"); //Para ingresar a la página
        //    //Para expandir las opciones                                                     // Expandir las opciones
        //    driver.FindElement(By.XPath("//button[@title='Toggle']")).Click();
        //    driver.FindElement(By.XPath("//li[3]//span[1]//button[1]")).Click();

        //    // Seleccionar la opcion Excel
        //    driver.FindElement(By.CssSelector("label[for='tree-node-excelFile']")).Click();
        //    string palabra = driver.FindElement(By.CssSelector(".text-success")).Text;
        //    // Validación con IF
        //    if (!palabra.Contains("wordFile"))
        //    {
        //        Assert.Pass("❌ El checkbox seleccionado NO es Excel.");
        //        Console.WriteLine("El checkbox seleccionado no es Excel, intente de nuevo.");
        //    }
        //    else
        //    {
        //        Assert.That(palabra, Does.Contain("excelFile"));
        //        Console.WriteLine("✅ El checkbox de Excel está seleccionado correctamente.");
        //    }
        //    //Assert.That(driver.FindElement(By.CssSelector(".text-success")).Text, Is.EqualTo("excelFile")); //Valida si el checkbox de Excel está seleccionado
        //    //Console.WriteLine("Usted ha seleccionado la opción de excel");


        //}

        //[Test]
        //public void frutitas()
        //{
        //    driver.Navigate().GoToUrl("https://letcode.in/dropdowns"); //Para ingresar a la página
        //    //Para expandir las opciones                                                     // Expandir las opciones
        //   SelectElement fruita = new SelectElement (driver.FindElement(By.Id("fruits")));
        //    fruita.SelectByText("Apple");
        //    string frutaSeleccionada = fruita.SelectedOption.Text;
        //    if (frutaSeleccionada == "Mango")
        //    {
        //        Assert.That(driver.FindElement(By.CssSelector("p[class='subtitle']")).Text, Is.EqualTo("You have selected Mango"));
        //        Console.WriteLine("Usted ha seleccionado la fruta " + frutaSeleccionada);
        //    }
        //    else
        //    {
        //        Assert.Pass("La fruta seleccionada es " + frutaSeleccionada + "   no es Mango, intente de nuevo.");
        //        //Console.WriteLine("La fruta seleccionada es "+frutaSeleccionada +"   no es Mango, intente de nuevo.");
        //    }
        //   // Assert.That(fruita.SelectedOption.Text, Is.EqualTo("Mango"));
        
        //}

        //[Test]
        //public void loginFallidoContrasena()
        //{
        //    driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/"); //Para ingresar a la página
        //    driver.FindElement(By.Id("username")).SendKeys("student"); //Para ingresar el usuario, el usuario es student
        //    driver.FindElement(By.CssSelector("#password")).SendKeys("Password12"); //Para ingresar la contraseña, la contraseña es Password123
        //    driver.FindElement(By.Id("submit")).Click(); //Para hacer click en el botón de submit e ingresar a la sesión.
        //    Thread.Sleep(2000); //Espera de 6 segundos para que cargue la página.
        //    Assert.That(driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/section[1]/div[2]")).Text, Is.EqualTo("Your password is invalid!")); //Valida si el texto es igual a "Your password is invalid!"
        //    //Los asserts siempre van al final del test, se usan para validar que lo que se espera sea igual a lo que realmente sucede.
        //}
        //[Test]
        //public void loginFallidoUsuario()
        //{
        //    driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/"); //Para ingresar a la página
        //    driver.FindElement(By.Id("username")).SendKeys("student2"); //Para ingresar el usuario, el usuario es student
        //    driver.FindElement(By.CssSelector("#password")).SendKeys("Password123"); //Para ingresar la contraseña, la contraseña es Password123
        //    driver.FindElement(By.Id("submit")).Click(); //Para hacer click en el botón de submit e ingresar a la sesión.
        //    Thread.Sleep(2000); //Espera de 6 segundos para que cargue la página.
        //    Assert.That(driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[1]/section[1]/div[2]")).Text, Is.EqualTo("Your username is invalid!")); //Valida si el texto es igual a "Your username is invalid!"
        //    //Los asserts siempre van al final del test, se usan para validar que lo que se espera sea igual a lo que realmente sucede.
        //}

        //[TearDown]
        //public void TearDown()
        //{
        //    if (driver != null)
        //    {
        //        driver.Quit(); //Quito o cierro el driver.
        //        driver.Dispose(); // Liberar recursos explícitamente
        //        driver = null;
        //    }

        //    var options = new EdgeOptions(); //Se crea la variable, hace el llamado al driver que se utilizar�
        //    driver = new EdgeDriver(options);
        //}

        //[Test] //Los Test o el etiquetado de test siempre deben estar.
        //public void TestNavegar()
        //{

        //    var options = new EdgeOptions(); //Se crea la variable, hace el llamado al driver que se utilizar�
        //    driver = new EdgeDriver(options);
        //}

        //[Test] //Los Test o el etiquetado de test siempre deben estar.
        //public void TestNavegar()
        //{

        //    driver.Navigate().GoToUrl("https://www.bing.com"); //Siempre lleva punto y coma                                                  
        //    driver.Manage().Window.Maximize(); //para maximizar la ventana del navegador.
        //    // Assert.Pass();
        //}
        //[TearDown]
        //public void TearDown()
        //{
        //    driver.Quit(); //Quito o cierro el driver.

        //}
    }
}