using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2HerenciaSimpleIES
{
    public static class ExtensionClass

    {
        //Método para contar palabras de un string
        //Devuelve un entero
        public static int WordCount(this string word)
        {
            string[] aPalabras = word.TrimEnd().Split(' ','.',',' );
            return aPalabras.Length;
        }
        //Método para Poner primera letra en mayuscula y resto en minuscula de una palabra
        //Devuelve un string
        public static string FirstLetterToUpper(this string word)
        {
            string sSalida = word.ToLower();
            sSalida = char.ToUpper(sSalida[0]) + sSalida.Substring(1);

            return sSalida;
        }
        //Método para buscar y eliminar objeto coincidente de una lista
        //Devuelve un booleano de confirmación
        public static bool SeekRemove(this List<Persona> lPersona,Persona Ppersona)
        {
            return lPersona.Remove(Ppersona);
        }
    }
}
