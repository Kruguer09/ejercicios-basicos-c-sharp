using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjVirtualesAbstractas
{
    public class Nieta : HijaAbstracta
    {
        //Implemento el metodo virtual de la ClaseAbstracta
        //que en HijaAbstracta se definió como abstracto
        public override int MetodoVirtualRestar(int y, int z)
        {
            return z - y;
        }

        //Este método se definió como abstracto en ClaseAbstracta
        //En HijaAbstracta se implementó con un método de reemplazo (override)
        //Si yo quisiera volver a reemplazarlo, podría
        //public override int MetodoAbstractoSumar(int y, int z)
        //{
        //    return y + z+ 1000;
        //}
    }
}
