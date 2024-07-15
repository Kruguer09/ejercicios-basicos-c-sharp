using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjVirtualesAbstractas
{
    public abstract class ClaseAbstracta
    {
        //MÉTODO ABSTRACTO
        public abstract int MetodoAbstractoSumar(int y, int z);

        //MÉTODO VIRTUAL ya implementado
        public virtual int MetodoVirtualRestar(int y, int z)
        {
            return y - z;
        }

        //MÉTODO VIRTUAL ya implementado
        public virtual int MetodoVirtualMultiplicar(int y, int z)
        {
            return y*z;
        }
    }
}
