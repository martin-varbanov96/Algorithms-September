using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int sum=1;

    static void Main(string[] args)
    {
        Console.WriteLine("f(n)=");
        int a = int.Parse(Console.ReadLine());
        createFactorial(a);
        Console.WriteLine();

        //TODO can get over 35 FACtorial!
        Console.WriteLine("Factorial= {0}", sum);
    }

    static void createFactorial(int n)
    {
        if(n>0)
        {
            Console.Write("{0}!",n);
            sum *= n;
            createFactorial(n-1);
        }
    }
}