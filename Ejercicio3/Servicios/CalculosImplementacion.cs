using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.Servicios
{
    internal class CalculosImplementacion : CalculosInterfaz
    {
        public void hacerOperacion (int numero)
        {
            string cadena = "";  
         for (int contador = 1; contador <= numero; contador++)
                {
                 cadena = cadena + Convert.ToString(contador);
                Console.WriteLine(cadena);
                
                }
         
        }

    }
    
}
