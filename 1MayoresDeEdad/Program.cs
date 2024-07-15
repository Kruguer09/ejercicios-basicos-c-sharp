namespace _1MayoresDeEdad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lPersonas = new List<Persona>();
            int iContadorPersonas = 1;
            bool bControlaCiclo = false;
            bool bControlPersonas = false;
            lPersonas.AddRange(new[] { new Persona { SNombre = "JUAN", SApellidos = "LOPEZ CRUZ", IEdad = 25, SEmail = "X" }, new Persona { SNombre = "MARIA", SApellidos = "LUQue DE LOS RIOS", IEdad = 16, SEmail = "X" } });
            while (!bControlaCiclo)
            {
                Persona temporal = new Persona();
                Console.WriteLine("----PERSONA " + iContadorPersonas + "----");
                Console.Write("NOMBRE: ");
                temporal.SNombre = (Console.ReadLine());
                Console.Write("APELLIDOS: ");
                temporal.SApellidos = (Console.ReadLine());
                do
                {
                    temporal.IEdad = 0;
                    Console.Write("EDAD: ");
                    temporal.IEdad = int.Parse(Console.ReadLine());
                } while (temporal.IEdad < 0 || temporal.IEdad > 120);

                lPersonas.Add(temporal);
                do
                {
                    Console.Write("\t\t=>¿Desea introducir más personas? (SI/NO: ");
                    string sRespuesta = Console.ReadLine().ToLower();
                    if (sRespuesta.Equals("si") || sRespuesta.Equals("s"))
                    {
                        bControlPersonas = true;
                    }
                    else if (sRespuesta.Equals("no") || sRespuesta.Equals("n"))
                    {
                        bControlPersonas = true;
                        bControlaCiclo = true;

                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos.");
                    }

                } while (!bControlPersonas);

                iContadorPersonas++;
            }
            for (int i = 0; i < lPersonas.Count; i++)
            {
                Console.WriteLine(lPersonas[i].salida());
            }

        }
        
    }
}