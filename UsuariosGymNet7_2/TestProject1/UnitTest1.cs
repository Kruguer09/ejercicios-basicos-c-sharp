using UsuariosGymNet7;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        //Instancio la clase
        private ServicioUsuarioGym serv;
        private UsuarioGym usuario;
        [TestInitialize]
        public void Initialize()
        {
            //Inicializo la clase
            serv = new ServicioUsuarioGym();
            usuario = new UsuarioGym();

        }

        // ##########################   Test IMC      ####################
        [TestMethod]
        [DataRow(70, 1.71)]
        [DataRow(30, 1.71)]
        [DataRow(130, 1.71)]
        [DataRow(70, 1.30)]
        [DataRow(70, 2.30)]

        public void CalcularIMCTestCorrecto(int peso, double altura)
        {
            //Arrange: inicializar las variables

            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;//cuadrado 3.24
            usuario.Edad = 45;
            double esperado = peso / (altura * altura);

            //Act
            double resultado = serv.CalcularIMC(usuario);

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
    }
}