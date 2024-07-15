namespace _2CalcularAreaFiguras;
public class Program
{
    static void Main(string[] args)
    {
        String textArea = "CALCULA EL AREA";
        int opcion = 1; /*establezco una primera opción del switch con la intención de que entre una vez en el programa y 
                         * se vuelva a ejecutar hasta que no se pulse la opción de salir (opción 4)*/
        double area=0.0;

        do
        {
            
            Console.Write(textArea + "\n");
            Console.WriteLine("\n\n\t1.Cuadrado\n\t2.Círculo\n\t3.Rectángulo\n\t4.Triángulo\n\t5.Salir");

            Console.Write("\nSelecciona la figura: ");
            do
            {
                opcion = validarEntero();
                Console.Clear();
                if (opcion < 1 || opcion > 5) Console.Write("¡Error! Inserte una opción correcta: ");
            } while (opcion < 1 || opcion > 5);

            switch (opcion)
            {
                case 1:
                    introduceDatos(opcion, out area);
                    areaCuadrado(area); break;
                case 2:
                    introduceDatos(opcion, out area);
                    areaCirculo(area);break;
                case 3:
                    introduceDatos(opcion, out area);
                    areaRectangulo(area); break;
                case 4:
                    introduceDatos(opcion, out area);
                    areaTriangulo(area); ; break;
            }
        } while (opcion != 5);
       
    }

    public static int validarEntero()=>Int32.TryParse(Console.ReadLine(), out int numero)? numero :0;
    
    public static double introduceDatos(int opcion, out double area)
    {
        //todo validar positivos
        area = 0.0;
        if (opcion == 1)
        {
            Console.Write("\nIntroduce el lado del cuadrado: ");
            double lado = Convert.ToDouble(Console.ReadLine());
            area = CuadradoArea(lado);
            return area;
        }
        else if(opcion == 2)
        {
            Console.Write("\nIntroduce el radio del círculo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            area = CirculoArea(radio);
            return area;
        }
        else if(opcion == 3)
        {
            Console.Write("\nIntroduce la base del rectángulo: ");
            double ladoBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nIntroduce la altura del rectángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            area = RectanguloArea(ladoBase, altura);
            return area;
        }
        else if (opcion == 4)
        {
            Console.Write("Introduce la base del triángulo: ");
            double ladoBase = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la altura del triángulo: ");
            double altura = Convert.ToDouble(Console.ReadLine());
            area = TrianguloArea(ladoBase, altura);
            return area;
        }
        return area;
    }

    public static double TrianguloArea(double ladoBase, double altura)
    {
        return (ladoBase * altura) / 2;
    }

    public static double RectanguloArea(double ladoBase, double altura)
    {
        return ladoBase * altura;
    }

    public static double CirculoArea(double radio)
    {
        return Math.PI * Math.Pow(radio, 2);
    }

    public static double CuadradoArea(double lado)
    {
        return lado * lado;
    }

    private static void areaCuadrado(double area) => Console.Write("\nEl area del cuadrado es: " + area);
    private static void areaCirculo(double area) => Console.Write("\nEl area del círculo es: " + area);
    private static void areaRectangulo(double area) => Console.Write("\nEl area del rectángulo es: " + area);
    private static void areaTriangulo(double area) => Console.Write("\nEl area del triángulo es: " + area);
    
}