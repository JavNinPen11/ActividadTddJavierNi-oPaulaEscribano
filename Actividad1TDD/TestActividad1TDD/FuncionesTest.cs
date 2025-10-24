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
}