using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstRepositoryTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "";
            while (n!="2")
            {
                Console.WriteLine("Type 2 to exit");
                n=Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
