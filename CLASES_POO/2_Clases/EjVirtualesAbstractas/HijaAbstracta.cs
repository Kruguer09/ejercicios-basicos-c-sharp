using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjVirtualesAbstractas
{
    public abstract class HijaAbstracta : ClaseAbstracta
    {
       //Implemento el método abstracto 
        public override int MetodoAbstractoSumar(int y, int z)
        {
            return y + z;
        }
        //Sobreescribo la definición del método virtual y lo convierto en abstracto
        public abstract override int MetodoVirtualRestar(int y, int z);

        //No toco el método MétodoVirtualMultiplicar, aunque podría sobreescribirlo

    }
}
