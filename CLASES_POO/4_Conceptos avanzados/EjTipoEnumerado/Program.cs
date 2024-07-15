namespace EjTipoEnumerado
{
    enum Color
    {
        //Tienen asignados los valores de constante por defecto
        Rojo, //=0
        Verde,//1
        Azul//2
    }

    //Cambiamos el tipo subyacente a uint
    enum Estacion : uint
    {
        //Asignamos los valores a cada constante
        Primavera = 1,
        Verano = 2,
        Otoño = 3,
        Invierno = 4
    }

    class Program
    {
        //Método que recibe una variable
        //del tipo enumerado Color como parámetro
        static void ImprimirColor(Color color)
        {
            switch (color)
            {
                case Color.Rojo:
                    Console.WriteLine("Rojo");
                    break;
                case Color.Verde:
                    Console.WriteLine("Verde");
                    break;
                case Color.Azul:
                    Console.WriteLine("Azul");
                    break;
                default:
                    Console.WriteLine("Color desconocido");
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Creamos una variable del tipo enumerado Color
            //y le asignamos el valor rojo
            Color c = Color.Rojo;

            //Llamamos al método
            ImprimirColor(c);

            //Llamamos al método pasándole directamente
            //un valor (azul) del tipo enumerado
            ImprimirColor(Color.Azul);

            int i = (int)Color.Azul;     // int i = 2;
            Color c2 = (Color)2;         // Color c = Color.Azul;  
            uint est = (uint)Estacion.Invierno; //uint est=4;

            //El método ToString() aplicado a un valor de un enumerado
            //nos devuelve el nombre de dicho valor en formato texto
            string estacion = Estacion.Primavera.ToString();
            Console.WriteLine(estacion);
            Console.ReadKey();
        }
    }
}