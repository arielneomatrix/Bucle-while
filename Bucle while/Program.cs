using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucle_while
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            while (contador < 100)
            {
                Console.WriteLine("El contador es: " + contador);
                contador++;

                contador = contador + 2; // Incrementa el contador en 2

            }

            Console.ReadKey();
        }
    }
}
