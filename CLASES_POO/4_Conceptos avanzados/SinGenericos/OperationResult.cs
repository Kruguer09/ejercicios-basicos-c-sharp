using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinGenericos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
    }
    //Clase que se conecta a una API. Si todo va bien recojo una serie de mensajes
    //devueltos al conectarme y el objeto persona devuelto 
    public class OperationResult
    {
        public bool Success => !MessageList.Any(); //Devuelvo la lista si no está vacía
        
        //Propiedades
        public List<string> MessageList { get; private set; }
        public Persona Persona { get; set; }

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
        //Le asigno una persona a mi propiedad Persona
        public void SetSuccesResponse(Persona pers)
        {
            Persona = pers;
        }
    }
}
