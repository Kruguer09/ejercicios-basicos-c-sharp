using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClasesYEstructuras
{
    public class Point
    {
        //Forma abreviada de crear una PROPIEDAD. Es equivalente a:
        //private int x;
        //public int X
        //{ 
        //  get{return x;}
        //  set{x = value;}
        //}
        public int X { get; set; }

        public int Y { get; set; }
    }
}
