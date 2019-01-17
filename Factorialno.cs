using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorialno.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int f = 1;
            Console.WriteLine("Enter a number to get its factorial");
            int no = int.Parse(Console.ReadLine());
            for(int i=0; i<=no; i++)
            {
                f = no * i;
            }
            Console.WriteLine(f);
            Console.ReadLine();

        }
    }
}
