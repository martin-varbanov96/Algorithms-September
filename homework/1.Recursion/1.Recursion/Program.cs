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
        if(bottomDisk==1)  
        {
            destination.Push(source.Pop());
        }
        else
        {
            MoveDisks(bottomDisk-1, source, spare, destination);         
            destination.Push(source.Pop());
            MoveDisks(bottomDisk, spare, destination, source);
        }
    }
    
}

