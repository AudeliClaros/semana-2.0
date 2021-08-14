using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_2._0
{
    class ejercicio_2
    {

        static void Main(string[] args)
        {
            int valor1, valor2, solución1, solución2;
            Console.WriteLine("Coloque primer valor");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Coloque segundo valor");
            valor2 = int.Parse(Console.ReadLine());
            solución1 = (valor1 + valor2) * (valor1 - valor2);
            solución2 = valor1 * 2 - valor2;
            Console.WriteLine("Solución1 (a+b)*(a-b) es igual: " + solución1);
            Console.WriteLine("Solución2 a2 - b es igual: " + solución2);
            Console.ReadKey();

        }


    }
}