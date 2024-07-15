using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjPerro; //Referencia al espacio de nombres donde tengo declarado la clase Perro


namespace EjTiposDatosAbstractos
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Jesús";
            Perro miperro = new Perro();
            miperro.Nombre = "coco";

        }
    }
}
