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

        fibunachiRow(start, max, 0, 0);
    }

    private static void fibunachiRow(int start, int max, int second, int third)
    {
        if(third==0)
        {
            fibunachiRow(start, max, start, (start+start));
            return;
        }

        if ((start <= max) && (second <= max) && (third<=max))
        {
            Console.WriteLine(" {0} ",start);
            fibunachiRow((start + second), max, start, second);
        }
    }
}