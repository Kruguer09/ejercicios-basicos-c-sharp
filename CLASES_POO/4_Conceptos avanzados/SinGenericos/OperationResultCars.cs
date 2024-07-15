using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinGenericos
{
    public class Car
    {
        public string Matricula { get; set; }
    }
    //Clase que se conecta a una API. Si todo va bien recojo una serie de mensajes
    //devueltos al conectarme y el objeto coche devuelto 
    public class OperationResultCars
    {
        public bool Success => !MessageList.Any();//Devuelvo la lista si no está vacía

        //Propiedades
        public List<string> MessageList { get; private set; }
        public Car Coche { get; set; }

        //Constructor
        public OperationResultCars()
        {
            MessageList = new List<string>();
        }

        //Añado un mensaje a la lista de mensajes
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        //Le asigno un coche a mi propiedad Coche
        public void SetSuccesResponse(Car coche)
        {
            Coche = coche;
        }
    }
}
