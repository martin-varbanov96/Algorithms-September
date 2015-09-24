using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter seed");
        char a = char.Parse(Console.ReadLine());
        charMatrix(a);
    }

    private static void charMatrix(char a)
    {
        Random rnd = new Random();
        if(a%233==12)
        {
            Console.WriteLine("END!!!");
        }

        a = (Char)rnd.Next(0, 126);
        Console.Write(a);
        charMatrix(a);
    }
}