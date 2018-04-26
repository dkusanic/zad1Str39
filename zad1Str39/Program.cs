using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1Str39
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            Console.WriteLine("Unesite broj N: ");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj M: ");
            M = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
                Console.WriteLine("crno \n");
            for (int i = 0; i < M; i++)
                Console.WriteLine("bijelo \n");
            Console.ReadLine();
        }
    }
}
