using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter c=");
        int c = int.Parse(Console.ReadLine());

        int a = 0;
        do
        {
            Console.WriteLine("Enter a<c; a= ");
            a=int.Parse(Console.ReadLine());
        }
        while(a>c);

        int b = 0;
        do
        {
            Console.WriteLine("Enter b<c; b= ");
            b = int.Parse(Console.ReadLine());
        }
        while (b > c);
        getPitagoNumbersInRange(a,b,c,a,b,c);
    }

    private static void getPitagoNumbersInRange(int a, int b, int c, int aTemp, int bTemp, int cTemp)
    {
        if ((c * c) == (a * a) + (b * b) &&
            (c>a) &&
            (c>b) &&
            (a>0) &&
            (b>0)
            )
        {
            Console.WriteLine("Solution found: {0}*{0}=={1}*{1}+{2}*{2}", c, a, b);
        }
        if(a<1)
        {
            getPitagoNumbersInRange(aTemp, b-1, c, aTemp, bTemp, cTemp);
            return;
        }
        if(b<1)
        {
            getPitagoNumbersInRange(aTemp, bTemp, c-1, aTemp, bTemp, cTemp);
            return;
        }
        if (c > 0)
        {
            getPitagoNumbersInRange(a - 1, b, c, aTemp, bTemp, cTemp);
            return;
        }
    }
}