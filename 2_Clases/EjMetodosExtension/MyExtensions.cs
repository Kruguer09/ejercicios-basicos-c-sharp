using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethods
{
    //Clase estática para mis métodos de extensión
    public static class MyExtensions
    {
        //Defino mi MÉTODO DE EXTENSIÓN
        //Para definir el parámetro pongo:
        //THIS + TIPO a extender + nombre variable
        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}

