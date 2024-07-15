using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjGenericos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        public override string ToString()
        {
            return $"{Nombre} {Apellidos}";
        }
    }
    public class Car
    {
        public string Matricula { get; set; }

        public override string ToString()
        {
            return $"{Matricula}";
        }
    }
    //Clase genérica
    public class OperationResult<T>
    {
        public bool Success => !MessageList.Any();//Devuelvo la lista si no está vacía

        //Propiedades
        public List<string> MessageList { get; private set; }
        public T Response { get; set; }

        //Constructor
        public OperationResult()
        {
            MessageList = new List<string>();
        }

        //Añado un mensaje a la lista de mensajes
        public void AddMessage(string message)
        {
            MessageList.Add(message);
        }

        //Le asigno un objeto del tipo T a mi propiedad Response del tipo T
        public void SetSuccesResponse(T obj)
        {
            Response = obj;
        }
    }
}
