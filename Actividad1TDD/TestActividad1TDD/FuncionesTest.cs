using Actividad1TDD;

namespace TestActividad1TDD
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_DeberiaDevolverMenosUno_SiNumeroEsNegativo()
        {
            long resultado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado, "El factorial de un numero negativo deberia devolver -1");
        }

        [TestMethod]
        public void CalcularFactorial_DeberiaDevolverUno_SiNumeroEsCero()
        {
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado, "El factorial de 0 deberia devolver 1");
        }

        [TestMethod]
        public void CalcularFactorial_Correcto()
        {
            long resultado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, resultado, "El factorial de 5 deberia devolver 120");
        }
    }

    [TestClass]
    public class FuncionesTestEsContrasenyaValida
    {
        [TestMethod]
        public void EsContrasenyaValida_ContrasenyaVacia()
        {
            bool contrasenya = Funciones.EsContrasenyaValida("");
            Assert.AreEqual(false, contrasenya, "La Contraseña no puede estar vacia");
        }

        [TestMethod]
        public void EsContrasenyaValida_ContrasenyaNull()
        {
            bool contrasenya = Funciones.EsContrasenyaValida(null);
            Assert.AreEqual(false, contrasenya, "La Contraseña no puede ser null");
        }

        [TestMethod]
        public void EsContrasenyaValida_LongitudValida()
        {
            bool contrasenya = Funciones.EsContrasenyaValida("Abcde1!");
            Assert.AreEqual(false, contrasenya, "La Contraseña debe tener al menos 8 caracteres");
        }

        public void EsContrasenyaValida_ContenerHashTag()
        {
            bool contrasenya = Funciones.EsContrasenyaValida("Abcdefg1");
            Assert.AreEqual(false, contrasenya, "La Contraseña debe contener al menos un caracter #");
        }
    }
}