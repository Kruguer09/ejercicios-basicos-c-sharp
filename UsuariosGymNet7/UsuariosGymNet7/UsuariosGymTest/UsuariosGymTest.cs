using UsuariosGymNet7;


namespace UsuariosGymTest

{
    [TestClass]
    public class UsuariosGymTest
    {
        //Instancio la clase
        private ServicioUsuarioGym serv;
        private UsuarioGym usuario;
        [TestInitialize]
        public void Initialize()
        {
            //Instancio la clase
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
            double esperado = peso/(altura*altura);

            //Act
            double resultado= serv.CalcularIMC(usuario);

            //Assert

            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        [DataRow(70,0)]
        [DataRow(20,0)]
        [DataRow(90,0)]
        [DataRow(30,0)]
        [DataRow(200,0)]
        public void TestDivideCeroExcepcion(int peso, double altura)
        {
            // Arrange
            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;
            usuario.Edad = 45;
            //Act
            double resultado = serv.CalcularIMC(usuario);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow(0, 1.20)]
        [DataRow(0, 1.30)]
        [DataRow(0, 1.40)]
        [DataRow(0, 1.85)]
        [DataRow(0, 2.30)]
        [DataRow(0, 2.35)]
        public void TestPesoCeroExcepcion(int peso, double altura)
        {
            // Arrange
            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;
            usuario.Edad = 45;
            //Act
            double resultado = serv.CalcularIMC(usuario);

        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataRow(22,22, 2.35)]
        [DataRow(90, 90, 2.35)]
        [DataRow(15, 15, 2.35)]
        [DataRow(15, 15, 1.29)]
        [DataRow(35, 90, 2.31)]
        [DataRow(35, 29, 2.31)]
        public void TestUsuarioIncorrectoExcepcion(int edad,int peso, double altura)
        {
            // Arrange
            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;
            usuario.Edad = edad;
            //Act
            double resultado = serv.CalcularIMC(usuario);

        }
        // ##########################   Test UsuarioValido      ####################
        [TestMethod]
        [DataRow(30, 76, 1.85)]
        [DataRow(16, 30, 1.30)]
        [DataRow(89, 89, 2.30)]
        public void TestUsuarioValidoCorrecto(int edad, int peso, double altura)
        {
            // Arrange
            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;
            usuario.Edad = edad;


            //Act 
            bool resultado=serv.UsuarioValido(usuario);

            // Assert
            Assert.IsTrue(resultado);

        }
        [TestMethod]
        [DataRow(15, 76, 1.85)]
        [DataRow(90, 30, 1.30)]
        [DataRow(89, 29, 2.30)]
        [DataRow(89, 60, 2.31)]
        [DataRow(89, 60, 1.29)]
        public void TestUsuarioValidoIncorrecto(int edad, int peso, double altura)
        {
            // Arrange
            usuario.NumUsuario = 1;
            usuario.Peso = peso;
            usuario.Estatura = altura;
            usuario.Edad = edad;
           

            //Act 
            bool resultado = serv.UsuarioValido(usuario);

            // Assert
            Assert.IsFalse(resultado);

        }
    }
}