using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el día: ");
            string día = Console.ReadLine();
            Console.Write("Ingrese el mes: ");
            string mes = Console.ReadLine();
            Console.Write("Ingrese el año: ");
            string año = Console.ReadLine();
            if(!DateTime.TryParseExact(día+"/"+mes+"/"+año, "dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture,
                System.Globalization.DateTimeStyles.None, out DateTime Fecha))
            {
                Console.Write("La fecha no es válida.");
            }
            else{
                Console.Write("La fecha es válida.");
            }
            Console.ReadKey();
            
        }
    }
}
