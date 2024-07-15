using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1MayoresDeEdad 
{
    //descripción de la clase persona con sus parámetros nombre, apellidos, edad y email con sus getter y setter
    public class Persona : IEquatable<Persona>
    {
        private string sNombre;
        public string SNombre
        {
            get { return sNombre; } 
            set {sNombre =FormatoNombre(value); }
        }
        private string sApellidos;
        public string SApellidos
        { get { return sApellidos; } 
        set { sApellidos=FormatoNombre(value);
                SEmail = FormatoMail();//inicializo el correo
            }
        }
        private int iEdad;
        public int IEdad
        {
            get { return iEdad; }
            set {  iEdad = value; }
        }
        private string sEmail;
        public string SEmail
        {   get { return sEmail; } 
            set {  sEmail = FormatoMail(); } 
        }
        private string FormatoNombre(string nombre)
        {
            string sSalida = "";
            string sTemporal = "";
            string[]sNombre=nombre.Split(' ');
            for(int i = 0; sNombre.Length > i; i++)
            {
                sTemporal = sNombre[i].ToLower();
                sTemporal = char.ToUpper(sTemporal[0]) + sTemporal.Substring(1);
                sSalida = sSalida + sTemporal+" ";
            }
            

            return sSalida;

        }
        // Método para dar formato al email autogenerado
        private string FormatoMail()
        {
            string sSalida = "";
            string[] aApellidos = sApellidos.TrimEnd().Split(' ');
            if (aApellidos.Length < 2)
            {
                sSalida = sSalida + aApellidos[0].Substring(0,2).ToLower()+ aApellidos[0].Substring(0, 2).ToLower();
            }
            else
            {
                sSalida = sSalida + aApellidos[0].Substring(0, 2).ToLower() + aApellidos[1].Substring(0, 2).ToLower();
            }
            sSalida=sSalida+sNombre.Substring(0, 2).ToLower()+"@iestrassierra.com";

            return sSalida;
        }
        // Método de salida por consola de la información del objeto persona
        public String salida()
        {
            string sSalida = SNombre.PadRight(20) + SApellidos.PadRight(30) + SEmail.PadRight(30) + IEdad.ToString().PadRight(20);

            return sSalida;
        }

        public bool Equals(Persona? other)
        {
            throw new NotImplementedException();
        }
    }
}
