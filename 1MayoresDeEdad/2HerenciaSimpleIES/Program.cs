

using static _2HerenciaSimpleIES.Auxiliar;
using System.Collections.Generic;
using static _2HerenciaSimpleIES.IEmpleadoPublico;

namespace _2HerenciaSimpleIES
{
    public class Program
    {
        // programa que se llamará 2HerenciaSimpleIES. Hará lo mismo que el programa anterior (sin añadir la lista inventada),
        // es decir, sólo se añadirán las personas introducidas por teclado. Además ahora se pedirá que se especifique si la persona es Alumno o Profesor
        // Main que arranca el programa
        static void Main(string[] args)
        {
            List<Persona> lPersonas = new List<Persona>();
            inicioPrograma();
            seleccionMenu(lPersonas);
        }
        // Función que controla el menú principal del programa
        private static void seleccionMenu(List<Persona> lPersonas)
        {
            bool bControlaCiclo = false;
            int iSeleccion;
            do
            {
                Console.WriteLine("    => OPCION (1,2,3,4,5,6): ");
                bControlaCiclo = Int32.TryParse(Console.ReadLine(), out iSeleccion);
            } while (!bControlaCiclo || iSeleccion < 1 || iSeleccion > 6);
            switch (iSeleccion)
            {
                case 1:
                    agregarPersonas(lPersonas);
                    break;
                case 2:
                    visualizarPersonas(lPersonas);
                    break;
                case 3:
                    borrarPersona(lPersonas);
                    break;
                case 4:
                    datosEmpleado(lPersonas);
                    break;
                case 5:
                    obtenerMayor(lPersonas);
                    break;
                case 6:
                    salir();
                    break;
            }
        }
        // Menú que inserta datos para calcular el mayor de dos Personas
        private static void obtenerMayor(List<Persona> lPersonas)
        {
            ComparaPersonas();
            VovlerMenu(lPersonas);
        }
        // Método para retornar al menú principal
        private static void VovlerMenu(List<Persona> lPersonas)
        {
            Console.WriteLine("\n\nPulse una tecla para volver al menú");
            Console.ReadLine();
            inicioPrograma();
            seleccionMenu(lPersonas);
        }
        // Menú que inserta datos para mostrar los datos del empleado público
        private static void datosEmpleado(List<Persona> lPersona)
        {
            Console.Clear();
            Persona pTemporal = new Persona();
            Console.WriteLine("#######  DATOS DEl EMPLEADO #######");
            Console.Write("NOMBRE: ");
            pTemporal.SNombre = Console.ReadLine();
            Console.Write("APELLIDOS: ");
            pTemporal.SApellidos = Console.ReadLine();
            pTemporal.IEdad = revisaEdad();
            for (int i = 0; i < lPersona.Count; i++)
            {
                if (lPersona[i] is ProfesorFuncionario&& lPersona[i].SNombre.Equals(pTemporal.SNombre) && lPersona[i].SApellidos.Equals(pTemporal.SApellidos) && lPersona[i].IEdad.Equals(pTemporal.IEdad))
                {
                   
                        (int años, int meses, int dias) = ((ProfesorFuncionario)lPersona[i]).TiempoDeServicio();
                        Console.WriteLine($"Tiempo de servicio => Años: {años}, Meses: {meses}, Días: {dias}");
                        Console.WriteLine(" Nº de SEXENIOS: "+ ((ProfesorFuncionario)lPersona[i]).GetSexenios());
                        Console.WriteLine(" Nº de TRIENIOS: " + ((ProfesorFuncionario)lPersona[i]).GetTrienios());
                        VovlerMenu(lPersona);
                    
                }
                else
                {
                    Console.WriteLine("La persona no existe o no es un funcionario público.");
                    VovlerMenu(lPersona);
                }
            }     
        }
        // Método para eliminar personas
        private static void borrarPersona(List<Persona> lPersonas)
        {
            BuscaYBorraPersonas(lPersonas);
            VovlerMenu(lPersonas);
        }
        // Menú que muestra todo el contenido de la lista de personas clasificados en alumnos y profesores
        private static void visualizarPersonas(List<Persona>lPersonas)
        {
            ImprimeListaPersonas(lPersonas);
            VovlerMenu(lPersonas);
        }
        // Método que muestra menú y lógica para añador personas a la lista de personas
        private static void agregarPersonas(List<Persona> lPersonas)
        {
            Console.Clear();
            Console.WriteLine("----PERSONA----");
            Console.Write("NOMBRE: ");
            string sNombreTemporal = Console.ReadLine();
            Console.Write("APELLIDOS: ");
            string sApellidosTemporal = Console.ReadLine();
            int iEdadTemporal = revisaEdad();
            int iRolProfesorTemporal;
            do
            {
                Console.WriteLine("Elige una opción:\n1. Alumno\n2. Profesor    => OPCION (1,2):");
            } while (!Int32.TryParse(Console.ReadLine(), out iRolProfesorTemporal) || iRolProfesorTemporal < 0 || iRolProfesorTemporal > 2);
            if (iRolProfesorTemporal == 1)
            {
                bool bControlaCiclo = false;
                int iNumeroExpediente;
                do
                {
                    Console.Write("Nº DE EXPEDIENTE: ");
                    bControlaCiclo = Int32.TryParse(Console.ReadLine(), out iNumeroExpediente);

                } while (!bControlaCiclo || iNumeroExpediente < 0);
                Alumno alumno = new Alumno();
                alumno.SNombre = sNombreTemporal;
                alumno.SApellidos = sApellidosTemporal;
                alumno.IEdad = iEdadTemporal;
                alumno.INumeroExpediente = iNumeroExpediente;
                agregaPersonas(lPersonas, alumno);
            }
            else
            {
                Console.Write("MATERIA QUE IMPARTE: ");
                string sMateriaTemporal = Console.ReadLine();
                int iTipoProfesor;
                bool bControlaCiclo = false;
                do
                {
                    Console.Write("Elige el tipo de profesor:\n1. Interino\n2. En Prácticas\n3. De Carrera    => OPCION (1,2,3):");
                    bControlaCiclo = Int32.TryParse(Console.ReadLine(), out iTipoProfesor);

                } while (!bControlaCiclo || iTipoProfesor < 0 || iTipoProfesor > 3);
                if( iTipoProfesor == 1)
                {
                    ProfesorInterino pProfesorInterino = new ProfesorInterino(sNombreTemporal,sApellidosTemporal,iEdadTemporal);
                    pProfesorInterino.SMateria = sMateriaTemporal;
                    pProfesorInterino.TipoProfesor = (Profesor.TipoFuncionario)1;
                    agregaPersonas(lPersonas, pProfesorInterino);
                }else if( iTipoProfesor == 2)
                {
                    int iAnyoTemporal;
                    bool bControlaEdad= false;
                    ProfesorFuncionario pProfesorFuncionario= new ProfesorFuncionario(sNombreTemporal, sApellidosTemporal, iEdadTemporal);
                    do
                    {
                        Console.WriteLine("AÑO DE INGRESO al cuerpo: ");
                        bControlaEdad = Int32.TryParse(Console.ReadLine(), out iAnyoTemporal);
                    } while (!bControlaEdad || iAnyoTemporal < 1975 || iAnyoTemporal > 2024);
                    pProfesorFuncionario.SMateria = sMateriaTemporal;
                    pProfesorFuncionario.TipoProfesor = (Profesor.TipoFuncionario)2;
                    pProfesorFuncionario.IAnyoIngresoCuerpo = iAnyoTemporal;
                    bool bControlDestino= false;
                    do
                    {
                        Console.WriteLine("DESTINO DEFINITIVO (SI/NO): ");
                        string sSalida = Console.ReadLine().ToLower();
                        if (sSalida.Equals("si") || sSalida.Equals("s"))
                        {
                            pProfesorFuncionario.BDestinoDefinitivo = true;
                            bControlDestino=true;
                        }
                        else if (sSalida.Equals("no") || sSalida.Equals("n"))
                        {
                            bControlDestino = true;
                            pProfesorFuncionario.BDestinoDefinitivo = false;
                        }
                        else
                        {
                            Console.WriteLine("Datos incorrectos.");
                        }
                    }while (!bControlDestino);
                    int iSeguroTemporal;
                    bool bControlaSeguro= false;
                    do
                    {
                        Console.WriteLine("Elige el TIPO DE SEGURO MÉDICO:\n1. Seguridad Social\n2. Muface    => OPCION (1,2):");
                        bControlaSeguro= Int32.TryParse(Console.ReadLine(),out iSeguroTemporal);
                    } while (!bControlaSeguro || iSeguroTemporal < 0 || iSeguroTemporal > 2);
                    //pProfesorFuncionario.TipoSeguro = (IEmpleadoPublico.TipoMedico)iSeguroTemporal;
                    if (iSeguroTemporal == 1)
                    {
                        pProfesorFuncionario.TipoSeguro = (TipoMedico)1;
                    }
                    else
                    {
                        pProfesorFuncionario.TipoSeguro = (TipoMedico)2;
                    }
                    agregaPersonas(lPersonas, pProfesorFuncionario);
                }
                else
                {
                    int iAnyoTemporal;
                    bool bControlaEdad = false;
                    ProfesorFuncionario pProfesorFuncionario = new ProfesorFuncionario(sNombreTemporal, sApellidosTemporal, iEdadTemporal);
                    do
                    {
                        Console.WriteLine("AÑO DE INGRESO al cuerpo: ");
                        bControlaEdad = Int32.TryParse(Console.ReadLine(), out iAnyoTemporal);
                    } while (!bControlaEdad || iAnyoTemporal < 1975 || iAnyoTemporal > 2024);
                    pProfesorFuncionario.SMateria = sMateriaTemporal;
                    pProfesorFuncionario.IAnyoIngresoCuerpo = iAnyoTemporal;
                    pProfesorFuncionario.TipoProfesor = (Profesor.TipoFuncionario)3;
                    bool bControlDestino = false;
                    do
                    {
                        Console.WriteLine("DESTINO DEFINITIVO (SI/NO): ");
                        string sSalida = Console.ReadLine().ToLower();
                        if (sSalida.Equals("si") || sSalida.Equals("s"))
                        {
                            pProfesorFuncionario.BDestinoDefinitivo = true;
                            bControlDestino = true;
                        }
                        else if (sSalida.Equals("no") || sSalida.Equals("n"))
                        {
                            bControlDestino = true;
                            pProfesorFuncionario.BDestinoDefinitivo = false;
                        }
                        else
                        {
                            Console.WriteLine("Datos incorrectos.");
                        }
                    } while (!bControlDestino);

                    int iSeguroTemporal;
                    bool bControlaSeguro = false;
                    do
                    {
                        Console.WriteLine("Elige el TIPO DE SEGURO MÉDICO:\n1. Seguridad Social\n2. Muface    => OPCION (1,2):");
                        bControlaSeguro = Int32.TryParse(Console.ReadLine(), out iSeguroTemporal);
                    } while (!bControlaSeguro || iSeguroTemporal < 0 || iSeguroTemporal > 2);
                    //pProfesorFuncionario.TipoSeguro = (IEmpleadoPublico.TipoMedico)iSeguroTemporal;
                    if (iSeguroTemporal == 1)
                    {
                        pProfesorFuncionario.TipoSeguro = (TipoMedico)1;
                    }
                    else
                    {
                        pProfesorFuncionario.TipoSeguro = (TipoMedico)2;
                    }
                    agregaPersonas(lPersonas, pProfesorFuncionario);

                }


            }

            Console.Write("\t\t=>¿Desea introducir más personas? (SI/NO:) ");
            string sRespuesta = Console.ReadLine().ToLower();
            if (sRespuesta.Equals("si") || sRespuesta.Equals("s"))
            {
                agregarPersonas(lPersonas);
            }
            else if (sRespuesta.Equals("no") || sRespuesta.Equals("n"))
            {
                inicioPrograma();
                seleccionMenu(lPersonas);

            }
            else
            {
                Console.WriteLine("Datos incorrectos.");
            }


        }
        // Método que inicia el menú principal del programa 
        private static void inicioPrograma()
        {
            Console.Clear();
            Console.WriteLine("  ############## MENU #####################");
            Console.WriteLine("  #  1. Añadir personas                   #");
            Console.WriteLine("  #  2. Visualizar personas               #");
            Console.WriteLine("  #  3. Borrar una persona                #");
            Console.WriteLine("  #  4. Datos de un empleado público      #");
            Console.WriteLine("  #  5. Obtener el mayor de dos personas  #");
            Console.WriteLine("  #  6. Salir                             #");
            Console.WriteLine("  #########################################");
        }
        // Menú de control para agregar Personas si no está repetida
        private static void agregaPersonas(List<Persona> lPersonas, Alumno alumno)
        {
            if (!personaRepetida(lPersonas, alumno))
            {
                lPersonas.Add(alumno);
                Console.WriteLine("El alumno  se agregaó.");
            }
        }
        private static void agregaPersonas(List<Persona> lPersonas, ProfesorInterino pProfesorInterino )
        {
            if (!personaRepetida(lPersonas, pProfesorInterino))
            {
                lPersonas.Add(pProfesorInterino);
                Console.WriteLine("El profesor interino  se agregaó.");
            }
        }
        // Método sobrecardo para controlar que no se repita ProfesorFuncionario
        private static void agregaPersonas(List<Persona> lPersonas, ProfesorFuncionario pProfesorFuncionario)
        {
            if (!personaRepetida(lPersonas, pProfesorFuncionario))
            {
                lPersonas.Add(pProfesorFuncionario);
                Console.WriteLine("El profesor en prácticas o funcionario  se agregaó.");
            }
        }

        public string anyoActual()
        {
            int anyo = DateTime.Now.Year % 100;
            string anyoActual = anyo.ToString();
            return anyoActual;
        }

    }
}