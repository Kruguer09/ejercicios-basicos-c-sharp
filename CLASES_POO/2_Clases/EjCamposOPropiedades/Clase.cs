using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjCamposOPropiedades
{
    public class Clase
    {
        //CAMPO
        //sin valor inicial
        public int Campo;

        //Con get y set damos nivel de accesibilidad a las propiedades
        //desde fuera de la clase
        //Podemos obtener y establecer los datos en la propiedad
        //Descriptores de acceso implementados automáticamente
        public string Nombre { get; set; }

        //Podemos obtener y establecer los datos en la propiedad
        //Descriptores de acceso implementados automáticamente
        public string Apellidos { get; set; }

        //Podemos obtener y NO establecer los datos en la propiedad
        public int Edad { get; private set; }

        //CAMPO DE RESPALDO telefono
        private long telefono;
        //FORMA 1
        //PROPIEDAD Telefono y descriptores de acceso
        //public long Telefono
        //{
        //    get => telefono;
        //    set => telefono= value > 99999999? value : 999999999;
        //}

        //FORMA 2
        //PROPIEDAD Telefono y descriptores de acceso
        public long Telefono
        {
            get { return telefono; }
            set
            {
                if (value > 99999999)
                    telefono = value;
                else
                    telefono = 999999999;
            }
        }


        //con valor inicial
        public int Estado = 1;

        //De SÓLO LECTURA:
        //Se le puede asignar un valor al declararla
        //O también en el constructor
        public readonly string Identificador = "XX"; 

        //Constructor
        public Clase()
        {
            Identificador = "ABCD";
            Edad = 10;
        }

        //Método que permite modificar la edad 
        //a los mayores de edad
        public void Metodo(int edad)
        {
          
            if (edad >= 18)
            {
                Edad = edad;
            }

            //ERROR:Aquí no se puede asignar un valor a 
            //la propiedad readonly
            //Identificador = "XXX";
        }
    }
}
