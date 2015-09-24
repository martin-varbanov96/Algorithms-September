using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static double result = 1;
    static void Main(string[] args)
    {
        Console.Write("Enter n= ");
        double n = double.Parse(Console.ReadLine());
        double k=0;

        do
        {
            Console.Write("Enter k<n k= ");
            k = double.Parse(Console.ReadLine());
        }
        while (k > n);

        genCombinations(n, k);
        Console.WriteLine(result);

    }

    private static void genCombinations(double n, double k)
    {
        if(k>0)
        {
            Console.Write("n={0}!",n);
            Console.Write("k={0}!",k);
            Console.Write("n-k={0}",(n-k));
            Console.WriteLine();
            //result*=n/(k*(n-k));
            result*=n/k;
            genCombinations(n-1,k-1);
        }
    }


}