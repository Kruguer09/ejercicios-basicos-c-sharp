namespace EjTiposDinamicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClaseEjemplo ec = new ClaseEjemplo();
            //ec.Metodo1(10, 4); ERROR. Metodo1 solo admite un parámetro en tiempo de compilación

            dynamic dynamic_ec = new ClaseEjemplo();
            //Puedo llamar a Metodo1 como quiera porque es desde un tipo dinámico
            //Sí fallará en tiempo de ejecución
            dynamic_ec.Metodo1(10, 4);

            //Puedo llamar a métodos que tal vez ni existan
            //porque desde los tipos dinámicos no se hace ninguna comprobación
            //en tiempo de compilación
            //para el compilador es como un Object
            dynamic_ec.algunMetodo("algún argumento", 7, null);
            dynamic_ec.metodoNoExistente();

            //A una variable dinámica le puedo asignar lo que yo quiera
            dynamic d = 8;
            //Si realizo una operación con su valor, el resultado también lo
            //considerará como dinámico
            var suma = d + 4;

        }
    }

    class ClaseEjemplo
    {
        //Constructor por defecto
        public ClaseEjemplo() { }
        public ClaseEjemplo(int v) { }

        public void Metodo1(int i) { }

        public void Metodo2(string str) { }
    }
}