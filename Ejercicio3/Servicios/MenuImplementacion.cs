using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int pedirNum()
        {
            Console.WriteLine("Introduzca un numero entero: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número entero introducido es: " + numero);
            return numero;
        }
        


        
    }
}
