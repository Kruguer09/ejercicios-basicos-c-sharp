using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjNivelesAccesibilidad
{
    public class ClaseBase
    {
        //Se puede acceder desde todos lados
        public string Telefono { get; set; }

        //Sólo se puede acceder desde la propia clase
        private int Edad { get; set; }

        //Sólo se puede acceder desde el mismo ensamblado
        internal string Nombre { get; set; }

        //Se puede acceder desde la propia clase y las clases derivadas
        protected string Apellidos { get; set; }

        //Se puede acceder desde el mismo ensamblado y desde las clases
        //derivadas aunque estén en otro ensamblado
        protected internal string Nacionalidad { get; set; }

        //Se puede acceder desde la misma clase y desde las clases
        //derivadas en el mismo ensamblado
        private protected string Direccion { get; set; }

        //Se puede acceder desde todos lados
        public int Sumar(int a, int b)
        {
            return a + b;
        }
    }
}
