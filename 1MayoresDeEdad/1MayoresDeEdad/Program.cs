using System.Collections.Generic;

namespace _1MayoresDeEdad
{
    public class Program
    {
        //1-Desarrollar un programa que se llamará 1MayoresDeEdad. Creará X instancias de la clase persona y pedirá sus nombres, apellidos y edad, validándolos todos. 
        static void Main(string[] args)
        {
            List<Persona> lPersonas = new List<Persona>();
            int iContadorPersonas = 1;
            int iEdadPersonas;
            bool bControlaCiclo = false;
            bool bControlPersonas = false;
            lPersonas = rellenaDatos(lPersonas);
            progPrincipal(lPersonas, ref iContadorPersonas, ref bControlaCiclo, ref bControlPersonas);
            Console.WriteLine("\n\n");
            imprimeLista(lPersonas);
            List<Persona> lPMayores = filtraMayoresEdad(lPersonas);
            Console.WriteLine("\n\n");
            imprimeLista(lPMayores);

        }

        private static int progPrincipal(List<Persona> lPersonas, ref int iContadorPersonas, ref bool bControlaCiclo, ref bool bControlPersonas)
        {
            int iEdadPersonas;
            do
            {
                Persona temporal = new Persona();
                Console.WriteLine("----PERSONA " + iContadorPersonas + "----");
                Console.Write("NOMBRE: ");
                temporal.SNombre = (Console.ReadLine());
                Console.Write("APELLIDOS: ");
                temporal.SApellidos = (Console.ReadLine());
                iEdadPersonas = revisaEdad();
                temporal.IEdad = iEdadPersonas;
                agregaPersona(lPersonas, temporal);

                masPersonas(ref bControlaCiclo, ref bControlPersonas);

                iContadorPersonas++;
            } while (!bControlaCiclo);
            return iEdadPersonas;
        }

        private static void agregaPersona(List<Persona> lPersonas, Persona temporal)
        {
            if (!personaRepetida(lPersonas, temporal))
            {
                lPersonas.Add(temporal);
                Console.WriteLine("La persona  se agregaó.");
            }
            else
            {
                Console.WriteLine("La persona ya existe en la lista. No se agregará.");
            }
        }

        public static void masPersonas(ref bool bControlaCiclo, ref bool bControlPersonas)
        {
            do
            {
                Console.Write("\t\t=>¿Desea introducir más personas? (SI/NO:) ");
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
        }

        private static int revisaEdad()
        {
            int iEdadPersonas;
            do
            {
                Console.Write("EDAD: ");
            } while (!Int32.TryParse(Console.ReadLine(), out iEdadPersonas) || iEdadPersonas < 0 || iEdadPersonas > 120);
            return iEdadPersonas;
        }

        //Método de rellenado de datos de ejemplo
        private static List<Persona> rellenaDatos(List<Persona>lPersonas)
        {
            lPersonas.AddRange(new[] { 
                new Persona { SNombre = "JUAN", SApellidos = "LOPEZ CRUZ", IEdad = 25, SEmail = "X" }, 
                new Persona { SNombre = "MARIA", SApellidos = "LUQue DE LOS RIOS", IEdad = 16, SEmail = "X" }, 
                new Persona { SNombre = "alejandra", SApellidos = "martinez monedero", IEdad = 8, SEmail = "X" }, 
                new Persona { SNombre = "Juan carlos", SApellidos = "banderas", IEdad = 78, SEmail = "X" }, 
                new Persona { SNombre = "Carolina", SApellidos = "vallejo sanchez", IEdad = 11, SEmail = "X" }, 
                new Persona { SNombre = "curro", SApellidos = "jimenez", IEdad = 25, SEmail = "X" } });
            return lPersonas;

        }
        //Función para salida por consola de la lista de objetos persona
        public static void imprimeLista(List<Persona> lPersonas)
        {
            Console.WriteLine("NOMBRE".PadRight(20) + "APELLIDOS".PadRight(30) + "EMAIL".PadRight(30) + "EDAD");
            for (int i = 0; i < lPersonas.Count; i++)
            {
                Console.WriteLine(lPersonas[i].salida());
            }
        }
        //Función que revisa que no esté repetido el objeto persona en la lista
        public static bool personaRepetida(List<Persona> listaPersonas, Persona personaNueva)
        {
            foreach (Persona personaExistente in listaPersonas)
            {
                if (personaExistente.SNombre.Equals(personaNueva.SNombre) &&
                    personaExistente.SApellidos.Equals(personaNueva.SApellidos))
                {
                    return true; 
                }
            }
            return false; 
        }
        //Método que filtra la lista para mostrar solo mayores de edad
        public static List<Persona> filtraMayoresEdad(List<Persona> lEntrada)
        {
            List < Persona > lSalida= new List < Persona >();
            foreach (Persona persona in lEntrada)
            {
                if (persona.IEdad>17)
                {
                    lSalida.Add(persona);
                }
            }
            return lSalida;
        }
    }
}