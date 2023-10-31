using Ejercicio3.Servicios;


namespace Ejercicio3.Controladores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            CalculosInterfaz ci = new CalculosImplementacion();


            int numero;
            numero = mi.pedirNum();

            ci.hacerOperacion(numero);
        }


    }

}
            

            