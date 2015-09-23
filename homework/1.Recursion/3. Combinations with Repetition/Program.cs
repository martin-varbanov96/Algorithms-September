using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.Write("n= ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k= ");
        int k = int.Parse(Console.ReadLine());
        int[] arr=new int[k];
        int index = 0;
        int startNum = 1;

        genCom(startNum, n, arr, index, k);
    }

    static void genCom(int start, int max, int[] arr, int index, int arrLength)
    {
        if(index==arr.Length){
            Console.WriteLine(String.Join(", ", arr));
        }
        else
        {
            //TODO optimize
            for (int i = start; i <= max; i++)
            {
                arr[index] = i;
                genCom(i+1, max, arr, index+1, arrLength);
            }
        }
    }
}
