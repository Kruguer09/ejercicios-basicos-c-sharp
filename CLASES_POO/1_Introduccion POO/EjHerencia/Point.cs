using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjHerencia
{
    public class Point
    {
        //Desde fuera de la clase se puede obtener el valor de X e Y
        //pero no se puede modificar, ya que los métodos set son private
        public int X { get; private set; }
        public int Y { get; private set; }

        public void SetX(int value)
        {
            if (value < 100)
                X = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public void SetY(int value)
        {
            if (value > 50)
                Y = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}

