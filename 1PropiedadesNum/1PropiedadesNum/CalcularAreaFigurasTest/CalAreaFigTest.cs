using _2CalcularAreaFiguras;
namespace CalcularAreaFigurasTest
{
    [TestClass]
    public class CalAreaFigTest
    {
        //No hago test incorrectos de las areas ya que tendría que ser negativos algunos de los valores
        //y se controla en el programa que no se le puedan pasar datos no correctos, o sea, enteros positivos
        [TestMethod]
        [DataRow(2,3,3)]
        [DataRow(10,20,100)]
        [DataRow(1,1,0.5)]
        public void TestTrianguloArea(double ladoBase, double altura, double esperado)
        {
            // Arrange inicializo las variables
  
            // Act ejecuto el método a probar
            double resultado = Program.TrianguloArea(ladoBase, altura);
            // Assert compruebo si el resultado es el esperado
            Assert.AreEqual(esperado, resultado);

        }
        [TestMethod]
        [DataRow(100000000000, 100000000000, 1000000000000000000/2)]
        [DataRow(0.000000000000001, 0.000000000000001, 0.00000000000000000000000000001/2)]
        // Pretendo mostrar que a valores muy grandes o muy pequeños no es adecuado el método o el tipo elegido
        public void TestTrianguloAreaIncorrecto(double ladoBase, double altura, double esperado)
        {
            // Arrange inicializo las variables

            // Act ejecuto el método a probar
            double resultado = Program.TrianguloArea(ladoBase, altura);
            // Assert compruebo si el resultado es el esperado
            Assert.AreNotEqual(esperado, resultado);

        }

        [TestMethod]
        [DataRow(2,3,6)]
        [DataRow(10,20,200)]
        public void TestRectanguloArea(double ladoBase, double altura, double esperado)
        {
            // Arrange inicializo las variables
 
            // Act ejecuto el método a probar
            double resultado = Program.RectanguloArea(ladoBase, altura);
            // Assert compruebo si el resultado es el esperado
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(100000000000, 200000000000, 2000000000000000000)]
        [DataRow(0.000000000000001, 0.000000000000002, 0.00000000000000000000000000002)]
        // Pretendo mostrar que a valores muy grandes o muy pequeños no es adecuado el método o el tipo elegido
        public void TestRectanguloAreaIncorrecto(double ladoBase, double altura, double esperado)
        {
            // Arrange inicializo las variables

            // Act ejecuto el método a probar
            double resultado = Program.RectanguloArea(ladoBase, altura);
            // Assert compruebo si el resultado es el esperado
            Assert.AreNotEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(2, Math.PI*2*2)]
        [DataRow(10, Math.PI*10*10)]
        [DataRow(1, Math.PI*1*1)]
        [DataRow(4245636547458, Math.PI* 4245636547508 * 4245636547408)]
        public void TestCirculoArea(double radio,double esperado)
        {
            // Arrange inicializo las variables
            //double rad = radio;
            //double esperado = Math.PI * (rad*rad);
            // Act ejecuto el método a probar
            double resultado = Program.CirculoArea(radio);
            // Assert compruebo si el resultado es el esperado
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
 
        [DataRow(984245636547458, Math.PI * 984245636547508 * 984245636547408)]
        [DataRow(0.000000000000001, Math.PI * 0.000000000000001 * 0.000000000000001)]
        // Pretendo mostrar que a valores muy grandes o muy pequeños no es adecuado el método o el tipo elegido
        public void TestCirculoAreaIncorrecto(double radio, double esperado)
        {
            // Arrange inicializo las variables
            //double rad = radio;
            //double esperado = Math.PI * (rad*rad);
            // Act ejecuto el método a probar
            double resultado = Program.CirculoArea(radio);
            // Assert compruebo si el resultado es el esperado
            Assert.AreNotEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(2,2*2)]
        [DataRow(10,10*10)]
        [DataRow(1,1*1)]
        public void TestCuadradoArea(double lado,double esperado)
        {
            // Arrange inicializo las variables
            //double l = lado;
            //double esperado = l * l;
            // Act ejecuto el método a probar
            double resultado = Program.CuadradoArea(lado);
            // Assert compruebo si el resultado es el esperado
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        [DataRow(100000000000, 1000000000000000000)]
        [DataRow(0.000000000000001, 0.00000000000000000000000000001)]
        // Pretendo mostrar que a valores muy grandes o muy pequeños no es adecuado el método o el tipo elegido
        public void TestCuadradoAreaIncorrecto(double lado, double esperado)
        {
            // Arrange inicializo las variables
            //double l = lado;
            //double esperado = l * l;
            // Act ejecuto el método a probar
            double resultado = Program.CuadradoArea(lado);
            // Assert compruebo si el resultado es el esperado
            Assert.AreNotEqual(esperado, resultado);
        }

    }
}