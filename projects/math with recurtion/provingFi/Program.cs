using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter max value= ");
        decimal max = decimal.Parse(Console.ReadLine());

        Console.Write("Enter start value= ");
        decimal start = decimal.Parse(Console.ReadLine());

        getAvgFi(start, max, 0, 0);
    }

    private static void getAvgFi(decimal start, decimal max, decimal b, decimal c)
    {
        if (c == 0)
        {
            getAvgFi(start + start, max, start, start);
            return;
        }
        if(start <= max)
        {
            Console.WriteLine("A= {0}, B= {1}, avg(fi)=A/B= {2}",start, b, (start/b));
            getAvgFi((start + b), max, (b + c), (start-c));
        }
    }
}