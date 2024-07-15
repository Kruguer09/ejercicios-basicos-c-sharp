namespace EjGenericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Clase genérica con un string
            string responseString = "texto";
            OperationResult<string> optResult = new OperationResult<string>();
            optResult.SetSuccesResponse(responseString);
            Console.WriteLine($"Response es un string = {optResult.Response}");

            //Clase genérica con un int
            int responseInt = 3242;
            OperationResult<int> optResult2 = new OperationResult<int>();
            optResult2.SetSuccesResponse(responseInt);
            Console.WriteLine($"Response es un int = {optResult2.Response}");

            //Clase genérica con un objeto Persona
            Persona responsePersona1 = new Persona();
            responsePersona1.Nombre = "Ana";
            responsePersona1.Apellidos = "López Díaz";
            OperationResult<Persona> optResult3 = new OperationResult<Persona>();
            optResult3.SetSuccesResponse(responsePersona1);
            Console.WriteLine($"Response es una persona = {optResult3.Response}");

            //Clase genérica con un objeto Car
            Car responseCar1 = new Car();
            responseCar1.Matricula = "BCD1234";
            OperationResult<Car> optResult4 = new OperationResult<Car>();
            optResult4.SetSuccesResponse(responseCar1);
            Console.WriteLine($"Response es un coche = {optResult4.Response}");
        }
    }
}