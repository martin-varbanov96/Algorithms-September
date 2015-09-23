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
        int[] arr=new int[n];
        int startNum=1;
        int index = 0;

        genLoop(n, arr, startNum, index);
    }

     static void genLoop(int n, int[] arr, int start, int index)
    {
         if(index==arr.Length){
             Console.WriteLine(String.Join(", ", arr));
         }
         else
         {
             //TODO optimize for to recurcive method
             for (int i = start; i <= n; i++)
             {
                 arr[index] = i;
                 genLoop(n, arr, start, index+1);
             }
         }
    }
}