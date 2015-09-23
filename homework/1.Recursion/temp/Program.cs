using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> a = new Stack<int>();
            a.Push(4);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            } a.Pop();
            foreach (var i in a)
            {
                Console.WriteLine(i);
            } a.Push(5);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
