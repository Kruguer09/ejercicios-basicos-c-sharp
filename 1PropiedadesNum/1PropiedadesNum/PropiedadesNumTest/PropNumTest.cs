

using _1PropiedadesNum;

namespace PropiedadesNumTest
{
    [TestClass]
    public class PropNumTest
    {
        private int num;
        [TestMethod]
        [DataRow(5,120)]
        [DataRow(7, 5040)]
        [DataRow(1, 1)]
        [DataRow(0, 1)]

        public void TestFactorialCorrecto(int numero, int esperado)
        {
            // Arrange inicializo las variables

            
            // Act ejecuto el método a probar
            int resultado = Program.factorial(numero);
            // Assert compruebo si el resultado es el esperado
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(20, 2432902008176640000)]
        [DataRow(19, 121645100408832000)]

        //Demuestro con números medianos por la poca precisión de la variable que no es el tipo más adecuado
        public void TestFactorialIncorrecto(int numero, long esperado)
        {
            // Arrange inicializo las variables


            // Act ejecuto el método a probar
            int resultado = Program.factorial(numero);
            // Assert compruebo si el resultado es el esperado
            Assert.AreNotEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(5)]
        [DataRow(11)]
        [DataRow(13)]
        [DataRow(19)]
        [DataRow(10601)]
        public void TestEsPrimoCorrecto(int numero)
        {
            // Arrange inicializo las variables
            num = numero;
            //bool esperado = true;
            // Act ejecuto el método a probar
            bool resultado = Program.esPrimo(num);
            // Assert compruebo si el resultado es el esperado
            Assert.IsTrue(resultado);
        }
        [TestMethod]
        [DataRow(6)]
        [DataRow(4)]
        [DataRow(9)]
        [DataRow(15)]
        [DataRow(21250)]
        public void TestEsPrimoIncorrecto(int numero)
        {
            // Arrange inicializo las variables
            num = numero;
            //bool esperado = false;
            // Act ejecuto el método a probar
            bool resultado = Program.esPrimo(num);
            // Assert compruebo si el resultado es el esperado
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        [DataRow(6,new int[] {1,2,3,6 })]
		[DataRow(12, new int[] { 1, 2, 3, 4, 6, 12 })]
		[DataRow(20, new int[] { 1, 2, 4, 5, 10, 20 })]
		[DataRow(30, new int[] { 1, 2, 3, 5, 6, 10, 15, 30 })]
		[DataRow(100, new int[] { 1, 2, 4, 5, 10, 20, 25, 50, 100 })]
		[DataRow(500, new int[] { 1, 2, 4, 5, 10, 20, 25, 50, 100, 125, 250, 500 })]

		public void TestDivisoresCorrecto(int numero, int[] esperado)
        {
            // Arrange inicializo las variables

            //metodo que devuelve una lista do los divisores de un número
            num = numero;
            int[] lEsperado = esperado;
            
            List<int> resultado = Program.divisores(num);
            // Assert compruebo si el resultado es el esperado
            CollectionAssert.AreEqual(lEsperado, resultado);
        }

        
    }
}