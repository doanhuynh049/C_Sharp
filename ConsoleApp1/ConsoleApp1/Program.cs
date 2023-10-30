using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicKnowledge;

namespace HelloWorld
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Swap<int>(ref a, ref b);
            string x = "Hello";
            string y = "World";
            Swap(ref x, ref y);
            Console.ReadLine();
        }
    }
}
