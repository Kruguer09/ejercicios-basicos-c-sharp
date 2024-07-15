using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPolimorfismo
{
    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("El gato hace miiiiau");
        }
    }
}
