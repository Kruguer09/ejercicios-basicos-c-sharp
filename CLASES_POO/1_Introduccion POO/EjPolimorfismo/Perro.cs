using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPolimorfismo
{
    class Perro : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El perro hace Guau Guau");
        }
    }
}
