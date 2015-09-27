using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    public static void Main()
    {
        Stack<int> source = new Stack<int>(Enumerable.Range(1,3).Reverse());
        Stack<int> destination = new Stack<int>();
        Stack<int> spare = new Stack<int>();
        MoveDisks(3, source, destination, spare);
    }

    private static void MoveDisks(int bottomDisk, Stack<int> source, Stack<int> destination, Stack<int> spare)
    {
        if(bottomDisk < 1)
        {
            return;
        }
        else if(bottomDisk==1)  
        {
            destination.Push(source.Pop());
            printSolution(source, spare, destination);
            return;

        }
        else
        {
            MoveDisks(bottomDisk-1, source, spare, destination);         
            destination.Push(source.Pop());
            printSolution(source, spare, destination);
            MoveDisks(bottomDisk - 1, spare, destination, source);
        }
    }

    private static void printSolution(Stack<int> source, Stack<int> spare, Stack<int> destination)
    {
        Console.WriteLine("Source: {0}", string.Join(", ", source.Reverse()));
        Console.WriteLine("Destination: {0}", string.Join(", ", destination.Reverse()));
        Console.WriteLine("Spare: {0}", string.Join(", ", spare.Reverse()));
        Console.WriteLine();
    }
}

