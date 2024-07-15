using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjClasesSelladas
{
    //La clase sellada sí puede heredar
    public sealed class ClaseSealed:Clase
    {
        public int Edad { get; set; }
    }
        
}
