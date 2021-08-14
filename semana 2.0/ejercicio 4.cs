using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_2._0
{
    class ejercicio_4
    {
        static void Main (string[] args)
        {
            double c, f;
            Console.WriteLine("Cantidad de grados: ");
            c = Convert.ToDouble(Console.ReadLine());
            f = (9 / 5) * c + 32;
            Console.WriteLine("Grados Fahrenheit: " + f);
                Console.ReadKey(); 


        }
    }
}
