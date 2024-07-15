using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo una instancia de la clase Gato
            Gato gato = new Gato();
         
            //Creo una instancia de la clase Perro
            Perro perro = new Perro();
          
            //Creo una lista de Animales y añado al gato y perro
            List<Animal> zoo = new List<Animal>();
            zoo.Add(gato);
            zoo.Add(perro);
            
            //Recorro la lista de animales y llamo al método HacerRuido()
            //de cada elemento de la lista
            foreach (var animal in zoo)
            {
                animal.HacerRuido();
            }

            Console.ReadKey();
        }
    }
}
