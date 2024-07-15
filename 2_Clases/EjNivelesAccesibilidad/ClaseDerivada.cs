using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjNivelesAccesibilidad
{
    public class ClaseDerivada:ClaseBase
    {
        public ClaseDerivada()
        {
            //Mediante base. intento acceder a los miembros
            //de la clase base

            //NO PUEDO acceder a:
            //Edad porque es PRIVATE en la clase base
            //base.Edad = 15;

            //SI PUEDO acceder a: 
            //Telefono porque es PUBLIC en la clase base
            base.Telefono = "957454545";

            //Nombre porque es INTERNAL en la clase base
            base.Nombre = "Marta";

            //Apellidos porque es PROTECTED en la clase base
            base.Apellidos = "Serrano";

            //Nacionalidad porque es PROTECTED INTERNAL en la clase base
            base.Nacionalidad = "España";

            //Direccion porque es PRIVATE PROTECTED en la clase base
            base.Direccion = "Calle Tortuga";
           
        }       
    }
}
