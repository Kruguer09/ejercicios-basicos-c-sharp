using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjNivelesAccesibilidad;

namespace PruebaAccesibilidad
{
    //Heredo de ClaseBase que está en otro ensamblado (proyecto)
    class ClassDerivada2 : ClaseBase
    {
        public ClassDerivada2()
        {
            base.Apellidos = "Jiménez"; //protected
            base.Nacionalidad = "Rusa"; //protected internal
            base.Sumar(4, 5);//pública
            base.Telefono = "7656";//pública
        }
           
    }
}
