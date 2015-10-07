using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int value = 0;
    static int seedDefault = 240;
    static void Main(string[] args)
    {
        Console.WriteLine("Enter seed!=0, seed=  ");
        int seed = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter max value= ");
        int max = int.Parse(Console.ReadLine());
        getRandom(seed, max);
    }

    private static void getRandom(int seed, int max)
    {
        seed = 36969 * (seed + 65535) + (seed >> 16);
        seedDefault = 18000 * (seed & 65535) + (seed >> 16);
        value = (seed << 16) + seedDefault;
        if ((value <= max)&&(value>0))
        {
            Console.WriteLine(value);
        }
        else
        {
            getRandom(seed+1, max);
        }
     
    }
}