using System.Collections.Generic;

namespace UsuariosGymNet7
{
    public class ServicioUsuarioGym
    {
        public List<string> Errores { get; private set; }


        public bool UsuarioValido(UsuarioGym usu)
        {
            Errores = new List<string>();
            bool valido = true;

            //entre 16 y 89
            if (usu.Edad < 16 || usu.Edad >= 90)
            {
                Errores.Add("La edad debe estar dentro del rango 16-89");
                valido = false;
            }
            //>=30
            else if (usu.Peso < 30)
            {
                Errores.Add("El peso debe ser de al menos 30 kilos");
                valido = false;
            }
            //entre 1.30-2.30
            else if (usu.Estatura < 1.30 || usu.Estatura > 2.30)
            {
                Errores.Add("La estatura debe ser de al menos 130 cms e inferior a 230 cms");
                valido = false;
            }

            return valido;
        }

        public double CalcularIMC(UsuarioGym usu)
        {
            double imc = usu.Peso / ((usu.Estatura) * (usu.Estatura));
            return imc;
        }
    }
}
