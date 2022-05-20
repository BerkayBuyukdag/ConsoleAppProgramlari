using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Property property = new Property();
            property.KILO = 85;

            Console.WriteLine(property.KILO);
            Console.ReadKey();
        }
    }
}
