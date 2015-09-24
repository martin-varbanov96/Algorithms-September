using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{ 
    static void Main(string[] args)
    {
        Console.Write("max value= ");
        int max = int.Parse(Console.ReadLine());

        Console.Write("start value= ");
        int start = int.Parse(Console.ReadLine());

        fiRow(start, max);
    }

    private static void fiRow(int start, int max)
    {
        int b = 0;

        while(start<=max)
        {
            Console.Write(" {0} ", start);
            start += b;
            b = start - b;
        }
    }
}