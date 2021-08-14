using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace semana_2._0
{
    class ejercicio_6
    {
        static void Main(string[] args)
        {
            double notaI, notaII, notaIII, porcentajeI, porcentajeII, porcentajeIII, Notafinal;

            Console.WriteLine("Introduzca la primera nota equivalente a un 30% ");
            notaI = int.Parse(Console.ReadLine());
            porcentajeI = (notaI * 0.30);
            Console.WriteLine("La nota que introdujo es = " + notaI);
            Console.WriteLine("Su nota al tener el 30% es: " + porcentajeI);
            Console.WriteLine("__________");
            Console.WriteLine("Introduzca la segunda nota equivalente a un 35% ");
            notaII = int.Parse(Console.ReadLine());
            porcentajeII = (notaII * 0.35);
            Console.WriteLine("La nota que introdujo es = " + notaII);
            Console.WriteLine("Su nota al tener el 35% es: " + porcentajeII);
            Console.WriteLine("__________");
            Console.WriteLine("Introduzca la tercera nota equivalente a un 25% ");
            notaIII = int.Parse(Console.ReadLine());
            porcentajeIII = (notaIII * 0.25);
            Console.WriteLine("La nota que introdujo es = " + notaIII);
            Console.WriteLine("Su nota al tener el 25% es: " + porcentajeIII);
            Console.WriteLine("__________");
            Notafinal = (porcentajeI + porcentajeII + porcentajeIII);
            Console.WriteLine("El resultado de su nota final es de: " + Notafinal);
            Console.WriteLine("__________");
            Console.ReadKey();
        }
    }
}

