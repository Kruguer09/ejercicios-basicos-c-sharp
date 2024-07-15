using System;

namespace EjClasesAbstractas_Interfaces
{
    //Clase abstracta
    public abstract class Vehiculos
    {
        public void Mover()
        {
            Console.WriteLine("Moviendo {0} ruedas del VEHICULO", Ruedas);
        }
        public virtual void Girar()
        {
            Console.WriteLine("Girando VEHICULO");
        }
        public abstract int Ruedas { get; }
    }

    //Clase derivada de Vehiculos
    //Tiene que SOBRECARGAR sólo los miembros abstractos
    //de la clase abstracta y opcionalmente los virtuales
    //E IMPLEMENTAR todos los miembros no implementados en la interfaz
    public class Coche : Vehiculos, IMedTransporte
    {
        //Método abstracto de la clase Vehiculos
        public override int Ruedas
        {
            get { return 4; }
        }

        //Propiedades de la interfaz IMedTransporte
       
        //Esta propiedad está implementada en la interfaz
        //No estoy obligado a implementarla en la clase derivada
        //A no ser que quiera acceder a ella desde una instancia
        //de dicha clase
        //public int Puertas
        //{
        //    get { return 5; }
        //}
       
        public bool EsAereo
        {
            get { return false; }
        }

        //Método virtual de la clase Vehiculos
        public override void Girar()
        {
            Console.WriteLine("Girando COCHE");
        }
    }

    //Clase derivada de Vehiculos
    //Tiene que SOBRECARGAR sólo los miembros abstractos
    //de la clase abstracta y opcionalmente los virtuales
    public class Bicicleta : Vehiculos
    {
        public override int Ruedas
        {
            get { return 2; }
        }
    }

    //Interfaz IVehiculos
    public interface IVehiculos
    {
        void Mover();
        int Ruedas { get; }
    }

    //Clase derivada de la interfaz IVehiculos
    //Tiene que implementar TODOS los miembros no implementados en la interfaz
    public class CocheI : IVehiculos
    {
        //Implementa la propiedad Ruedas
        public int Ruedas
        {
            get { return 4; }
        }

        //Implementa el método Mover
        public void Mover()
        {
            Console.WriteLine("Moviendo COCHEI");
        }
    }
    //Clase derivada de la interfaz IVehiculos
    //Tiene que implementar TODOS los miembros no implementados en la interfaz
    public class BicicletaI : IVehiculos
    {
        //Implementa la propiedad Ruedas
        public int Ruedas
        {
            get { return 2; }
        }

        //Implementa el método Mover
        public void Mover()
        {
            Console.WriteLine("Moviendo BICICLETAI");
        }
    }

    //Interfaz IMedTransporte
    public interface IMedTransporte
    {
        int Puertas { get => 2; }
        bool EsAereo { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //ERROR: no se pueden instanciar clases abstractas ni interfaces
            //Vehiculos vehiculo = new Vehiculos();
            //IVehiculos vehiculoI = new IVehiculos();

            Coche micoche = new Coche();
            Bicicleta mibici = new Bicicleta();
            CocheI micocheI = new CocheI();
            BicicletaI mibiciI = new BicicletaI();

            Console.WriteLine("----CLASE COCHE--- (derivada de Vehiculo y de la interfaz IMedTransporte)");
            //no se sobrecarga y se llama al método de la clase Vehiculo
            micoche.Mover();
            //se sobrecarga y se llama al método de la clase Coche
            micoche.Girar();

            //Esto da ERROR a no ser que implemente Puertas también en la clase derivada
            //se llama a la propiedad Puertas implementada en IMedTransporte
            //Console.WriteLine($"Es un medio de transporte con {micoche.Puertas.ToString()} puertas");

            Console.WriteLine("\n----CLASE BICILETA--- (derivada de Vehiculo)");
            //no se sobrecarga y se llama al método de la clase Vehiculo
            mibici.Mover();
            //no se sobrecarga y se llama al método de la clase Vehiculo
            mibici.Girar();

            Console.WriteLine("\n----CLASE COCHEI--- (derivada de IVehiculo)");
            //se implementa y se llama al método de la clase CocheI
            micocheI.Mover();

            Console.WriteLine("\n----CLASE BICII--- (derivada de IVehiculo)");
            //se implementa y se llama al método de la clase BicicletaI
            mibiciI.Mover();

            Console.ReadKey();
        }
    }
}
