using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjHerencia
{
    public class Point3D : Point
    {
        public int Z { get; private set; }
       
        public void SetZ(int value)
        {
            if (value < 30)
                Z = value;
            else
                throw new ArgumentOutOfRangeException();
        }

        public int GetZ()
        {
            return Z;
        }


    }
}
