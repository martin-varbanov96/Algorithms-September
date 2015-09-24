using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int sum = 1;
    static void Main(string[] args)
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        int k=0;
        do
        {
        Console.Write("Enter k>n; k= ");
        k = int.Parse(Console.ReadLine());
        }
        while (k > n);
        genVar(n, k);
        Console.WriteLine();
        Console.WriteLine(sum);
    }

    private static void genVar(int n, int k)
    {
        if(k>0)
        {
            sum *= n;
            Console.Write("{0}!", n);
            genVar(n-1,k-1);
        }
    }
}