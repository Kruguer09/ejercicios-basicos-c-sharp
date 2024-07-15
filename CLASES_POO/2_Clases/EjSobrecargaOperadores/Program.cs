using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjSobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Llamo al constructor que asigna valores a X e Y
            Punto punto1 = new Punto(200, 50);
            Punto punto2 = new Punto(100, 25);
            Console.WriteLine($"PUNTO 1: X = {punto1.X} Y = {punto1.Y}");
            Console.WriteLine($"PUNTO 2: X = {punto2.X} Y = {punto2.Y}\n");

            punto1++;
            Console.WriteLine($"PUNTO 1++:X = {punto1.X} Y = {punto1.Y}\n");

            punto1--;
            Console.WriteLine($"PUNTO 1--:X = {punto1.X} Y = {punto1.Y}\n");

            punto2 = punto1 + punto2;
            Console.WriteLine($"PUNTO 2=PUNTO 1 + PUNTO2\nX = {punto2.X} Y = {punto2.Y}\n");

            punto2--;

            Console.WriteLine($"PUNTO 2--: X = {punto2.X} Y = {punto2.Y}\n");

            //Llamo al constructor que inicializa X e Y a 0
            Punto puntoBool = new Punto();

            EsPuntoVacio(puntoBool);

            puntoBool.X = 10;
            puntoBool.Y = 20;

            EsPuntoVacio(puntoBool);

            Console.ReadKey();

        }
        //Uso de los operadores true y false aplicados a la clase Punto
        public static void EsPuntoVacio(Punto miPunto)
        {
            if (miPunto)
                Console.WriteLine($"PUNTO BOOL: X = {miPunto.X} Y = {miPunto.Y}");
            else
                Console.WriteLine($"PUNTO BOOL: punto vacío");
        }

    }

    public class Punto
    {
        //Propiedad y descriptores de acceso
        public int X { get; set; }
       
        //Propiedad y descriptores de acceso
        public int Y { get; set; }

        //Constructor por defecto
        public Punto()
        {
            X = 0; 
            Y = 0;
        }

        //Constructor con 2 parámetros 
        //como método de expresión corporal o bodied member
        public Punto(int x, int y) => (X, Y) = (x, y);

        //Constructor con 1 parámetro 
        //como método de expresión corporal o bodied member
        public Punto(int x) => (X, Y) = (x, 0);

        //Sobrecarga del operador ++
        public static Punto operator ++(Punto p)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = p.X + 1;
            nuevoPunto.Y = p.Y + 1;

            return nuevoPunto;
        }

        //Sobrecarga del operador --
        public static Punto operator --(Punto p)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = p.X - 1;
            nuevoPunto.Y = p.Y - 1;

            return nuevoPunto;
        }
        //Sobrecarga del operador +
        public static Punto operator +(Punto p1, Punto p2)
        {
            Punto nuevoPunto = new Punto();
            nuevoPunto.X = p1.X + p2.X;
            nuevoPunto.Y = p1.Y + p2.Y;

            return nuevoPunto;
        }

        //Sobrecarga de operador true y false
        //Si se define uno, el otro también obligatoriamente
        public static bool operator true(Punto p) => (p.X != 0 && p.Y != 0) ? true : false;
        public static bool operator false(Punto p) => (p.X == 0 || p.Y == 0) ? false : true;

    }
}
