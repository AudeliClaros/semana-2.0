using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            double costo = 0;
            int medicina = 0;

            string valor = "";
            double iva = 0;
            double totalfinal = 0;

            Console.WriteLine("Costo de su producto:");
            valor = Console.ReadLine();
            costo = Convert.ToDouble(valor);

            Console.WriteLine("En caso de ser medicamento coleque 1, si no es medicina coloque 2");
            valor = Console.ReadLine();
            medicina = Convert.ToInt32(valor);

            iva = Math.Round(costo * 0.13, 2);

            totalfinal = costo + iva;

            if (medicina != 2)
            {
                Console.WriteLine("No incluye IVA ");
                Console.WriteLine("Total a pagar:     {0} ", costo);

            }

            else if (medicina != 1)
            {
                Console.WriteLine("Si incluye IVA ");
                Console.WriteLine("Total a pagar:           {0} ", totalfinal);
            }

            Console.ReadKey();

        }
    }
}
      
