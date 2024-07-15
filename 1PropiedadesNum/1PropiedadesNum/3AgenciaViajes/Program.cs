namespace _3AgenciaViajes;
class Program
{
    static void Main(string[] args)
    {
        String textArea = "   _                         _             _              _        _           \n  /_\\   __ _  ___ _ __   ___(_) __ _    __| | ___  /\\   /(_) __ _ (_) ___  ___ \n //_\\\\ / _` |/ _ \\ '_ \\ / __| |/ _` |  / _` |/ _ \\ \\ \\ / / |/ _` || |/ _ \\/ __|\n/  _  \\ (_| |  __/ | | | (__| | (_| | | (_| |  __/  \\ V /| | (_| || |  __/\\__ \\\n\\_/ \\_/\\__, |\\___|_| |_|\\___|_|\\__,_|  \\__,_|\\___|   \\_/ |_|\\__,_|/ |\\___||___/\n       |___/                                                    |__/           ";
        int opcion = 1; /*establezco una primera opción del switch con la intención de que entre una vez en el programa y se vuelva a ejecutar hasta que no se pulse la opción de salir (opción 4)*/

        String[] origenAvion = { "malaga", "madrid", "sevilla", "barcelona", "bilbao", "madrid", "malaga", "madrid"};
        String[] destinoAvion = { "paris", "roma", "barcelona", "oslo", "berlin", "New york", "amsterdam", "caracas"};
        Double[] precioAvion = { 89.90, 125.99, 58.90, 220.45, 173.95, 638.84, 180.35, 483.13};

        String[] origenTren = { "cordoba", "madrid", "sevilla", "barcelona", "malaga" };
        String[] destinoTren = { "malaga", "vigo", "cadiz", "zaragoza", "valencia" };
        String[] precioTren = { "30.80", "90.30", "25.45", "40.49", "89.20" };

        String[][] infoTrenes = new string[3][];

    //MENU PRINCIPAL
        do
        {
            Console.Clear();
            Console.Write(textArea + "\n");
            Console.WriteLine("\n¿Qué desea comprar/reservar?:\n\n1. Billetes de avión\n2. Trayectos de avión\n3. Billetes de tren\n4. Trayectos de tren\n5. Salir");

            Console.Write("\nSeleccione una opción: ");
            do
            {
                opcion = validarEntero();
                if (opcion < 1 || opcion > 5) Console.Write("Introduzca una opción correcta: ");
            } while (opcion < 1 || opcion > 5);

            switch (opcion)
            {
                case 1: billetesAvion(origenAvion, destinoAvion, precioAvion);break;
                case 2: trayectosAvion(origenAvion, destinoAvion);break;
                case 3: billetesTren(origenTren, destinoTren, precioTren);break;
                case 4: trayectosTren(origenTren, destinoTren);break;
            }
        } while (opcion != 5);
    }


    static int validarEntero() => Int32.TryParse(Console.ReadLine(), out int numero)? numero : 0; //Expresión corporal de la función para validar un entero.


    //OPCION 1

    private static void billetesAvion(String[] origen, String[] destino, Double[] precio)
    {
        int numTarjeta;
        bool salirMenu = false;

        do
        {
            Console.Clear();
            Console.WriteLine("--- BILLETES DE AVION ---");
            Console.Write("\nOrigen (ESPAÑA): ");
            String ciudadOrigen = Console.ReadLine().ToLower();
            Console.Write("Destino (ESPAÑA): ");
            String ciudadDestino = Console.ReadLine().ToLower();

            for (int i = 0; i < origen.Length; i++) 
            {
                if (ciudadOrigen == origen[i] && ciudadDestino == destino[i])
                {
                    Console.WriteLine("\nEl precio del billete asciende a " + precio[i] + " €");
                    Console.WriteLine("\nSi tiene tarjeta de puntos, introdúzcala aquí para que le hagamos un descuento.\nSi no tiene tarjeta, introduzca 0.");
                    do
                    {
                        Console.Write("\nNº DE TARJETA: ");
                        Int32.TryParse(Console.ReadLine(), out numTarjeta);
                    } while (numTarjeta < 0);

                    if (numTarjeta > 0 && numTarjeta < 1000)
                    {
                        Console.WriteLine("\nLo sentimos, no tiene ningún descuento asociado a su tarjeta.\nEl PRECIO FINAL de su billete es de: " + precio[i] + " €");
                        Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                        salirMenu = true;
                        Console.ReadKey();
                    }
                    else if (numTarjeta == 0)
                    {
                        Console.WriteLine("\nEl PRECIO FINAL de su billete es de: " + precio[i] + " €");
                        Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                        salirMenu = true;
                        Console.ReadKey();
                        
                    }
                    else
                    {
                        double descuento = precio[i] * 0.90;
                        Console.WriteLine("\nHa obtenido un descuento del 10%.\nEl PRECIO FINAL de su billete es de " + Math.Round(descuento, 2) + " €");
                        Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                        salirMenu = true;
                        Console.ReadKey();
                    }
                }
            }
            if (salirMenu == false)
            {
                Console.WriteLine("\nLo sentimos. Ese trayecto no está disponible");
                Console.Write("¿Quiere probar con otro trayecto? (SI/NO): ");
                String reintentar = Console.ReadLine().ToLower();
                if (reintentar == "si")
                {
                    salirMenu = false;
                }
                else
                {
                    salirMenu = true;
                }
            }
            
        } while (salirMenu==false) ;
    }

    //OPCION 2

    private static void trayectosAvion(String[] origen, String[] destino)
    {
        Console.Clear();
        String cabecera = "           ______\n            _\\ _~-\\___\n    =  = ==(____AA____D\n                \\_____\\___________________,-~~~~~~~`-.._\n                /     o O o o o o O O o o o o o o O o  |\\_\n                `~-.__        ___..----..                  )\n                      `---~~\\___________/------------`````\n                      =  ===(_________D";
        Console.WriteLine("--------------- TRAYECTOS DE AVION ---------------");
        Console.WriteLine(cabecera);
        Console.Write("\n" + origen.Length + " trayectos disponibles:");
        Console.WriteLine("\n");
        for (int i = 0; i < origen.Length; i++)
        {
            Console.WriteLine("Trayecto "+(i+1)+"->  Origen: "+origen[i].ToUpper()+"\t  *****\t    Destino: "+destino[i].ToUpper());

        }
        Console.WriteLine("\nGRACIAS POR SU VISITA \nPulse cualquier tecla para volver al MENÚ PRINCIPAL....");
        Console.ReadKey();
    }

    //OPCION 3

    private static void billetesTren(String[]origen, String[]destino, String[] precio)
    {
        bool salirMenu = false;
        int opcion;
        

        do
        {
            Console.Clear();
            Console.WriteLine("--- BILLETES DE TREN ---");
            Console.Write("\nOrigen (ESPAÑA): ");
            String ciudadOrigen = Console.ReadLine().ToLower();
            Console.Write("Destino (ESPAÑA/EXTRANJERO): ");
            String ciudadDestino = Console.ReadLine().ToLower();

            for (int i = 0; i < origen.Length; i++)
            {
                if (ciudadOrigen == origen[i] && ciudadDestino == destino[i])
                {
                    Console.WriteLine("\nEl precio del billete asciende a " + precio[i] + " €");
                    Console.Write("\n1. Tarjeta dorada\n2. Carnet joven\n3. Familia Numerosa\n4. No tengo descuento");
                    Console.Write("\n\nSeleccione qué tipo de descuento tiene: ");

                    do
                    {
                        opcion = validarEntero();
                        if (opcion < 1 || opcion > 4) Console.Write("Introduzca una opción correcta: ");
                    } while (opcion < 1 || opcion > 4);

                    Double descuento;
                    switch (opcion)
                    {

                        case 1:
                            descuento = Convert.ToDouble(precio[i]) * 0.75;
                            Console.WriteLine("\nHa obtenido un descuento del 25%.\nEl PRECIO FINAL de su billete es de " + Math.Round(descuento, 2) + " €");
                            Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                            salirMenu = true;
                            Console.ReadKey();
                            break;

                        case 2:
                            descuento = Convert.ToDouble(precio[i]) * 0.75;
                            Console.WriteLine("\nHa obtenido un descuento del 25%.\nEl PRECIO FINAL de su billete es de " + Math.Round(descuento, 2) + " €");
                            Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                            salirMenu = true;
                            Console.ReadKey();
                            break;
                        case 3:
                            descuento = Convert.ToDouble(precio[i]) * 0.50;
                            Console.WriteLine("\nHa obtenido un descuento del 25%.\nEl PRECIO FINAL de su billete es de " + Math.Round(descuento, 2) + " €");
                            Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                            salirMenu = true;
                            Console.ReadKey();
                            break;
                        case 4:                          
                            Console.WriteLine("\nEl PRECIO FINAL de su billete es de: " + precio[i] + " €");
                            Console.WriteLine("\nPulse una tecla para volver al MENÚ PRINCIPAL....");
                            salirMenu = true;
                            Console.ReadKey();
                            break;
                            
                        default: break;
                    }

                }
            }
            if (salirMenu == false)
            {
                Console.WriteLine("\nLo sentimos. Ese trayecto no está disponible");
                Console.Write("¿Quiere probar con otro trayecto? (SI/NO): ");
                String reintentar = Console.ReadLine().ToLower();
                if (reintentar == "si")
                {
                    salirMenu = false;
                }
                else
                {
                    salirMenu = true;
                }
            }

        } while (salirMenu == false);
    }


    //OPCION 4

    private static void trayectosTren(String[] origen, String[] destino)
    {
        Console.Clear();
        String cabecera = "__________________________________________________________\n        ____<___________________    ______________________\n       /_] ###   AVE   ### [_\\  |[][___][___][___][___]\n      /__________________________\\ |Li____________________\n      +~o-o-o~============~o-o-o~+-+~ o=o\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"";
        Console.WriteLine("--------------- TRAYECTOS DE TREN ---------------");
        Console.WriteLine(cabecera);
        Console.Write("\n"+origen.Length + " trayectos disponibles:");
        Console.WriteLine("\n");
        for (int i = 0; i < origen.Length; i++)
        {
            Console.WriteLine("Trayecto " + (i + 1) + "->  Origen: " + origen[i].ToUpper() + "\t  *****\t    Destino: " + destino[i].ToUpper());

        }
        Console.WriteLine("\nGRACIAS POR SU VISITA \nPulse cualquier tecla para volver al MENÚ PRINCIPAL....");
        Console.ReadKey();
    }
}
    

