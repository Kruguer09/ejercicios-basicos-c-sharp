using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Incluyo el proyecto en referencias (Explorador de soluciones)
//e importo el espacio de nombres
using EjNivelesAccesibilidad; 

namespace PruebaAccesibilidad
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada cd = new ClaseDerivada();
            //Solamente puedo acceder al método y propiedad públicos
            //al estar en otro proyecto y no ser una clase derivada
            cd.Sumar(3, 4);
            cd.Telefono = "4327482";
        }
    }
}
