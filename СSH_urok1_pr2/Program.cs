using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СSH_urok1_pr2
{
    class Program
    {
        static void Main(string[] args)
        {
            Decimal devidend = decimal.One;
            Console.WriteLine(devidend);
            decimal devisor = 3;
            devidend = devidend / devisor;
            Console.WriteLine(devidend);
            Console.WriteLine(devidend * devisor);
            Console.WriteLine("Round");
            Console.WriteLine(Math.Round(devidend * devisor));
            double doubleDevidend = 1;
            Console.WriteLine(doubleDevidend);
            System.Double doubleDevisor = 3;
            doubleDevidend = doubleDevidend / doubleDevisor;
            Console.WriteLine(doubleDevidend);
            Console.WriteLine(doubleDevidend * doubleDevisor);
        }
    }
}
