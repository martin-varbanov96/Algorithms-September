using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static char[,] lab = 
    {
        {'S', ' ', ' ', ' '},
        {' ', '*', '*', ' '},
        {' ', '*', '*', ' '},
        {' ', '*', 'e', ' '},
        {' ', ' ', ' ', ' '},
        //{' ', ' ', ' ', '*', ' ', ' ', ' '},
        //{'*', '*', ' ', '*', ' ', '*', ' '},
        //{' ', ' ', ' ', ' ', ' ', ' ', ' '},
        //{' ', '*', '*', '*', '*', '*', ' '},
        //{' ', ' ', ' ', ' ', ' ', ' ', 'e'},
    };
    static List<Tuple<int, int>> path = new List<Tuple<int, int>>();
    static Stack<char> result=new Stack<char>();

     
    static void Main(string[] args)
    {

        findPath(0,0,'S');
    }
    static void findPath(int row, int col, char sign)
    {
        if(!isInRange(row, col)){
            return;
        }
        if(lab[row, col]=='e')
        {
            PrintPath(row, col);
        }
        if((lab[row, col]==' ')||(lab[row, col]=='S')){
            
        path.Add(new Tuple<int, int>(row, col));
        lab[row, col]=sign;
        result.Push(sign);

        findPath(row,col+1, 'R');//R
        findPath(row-1,col, 'U');//u
        findPath(row,col-1, 'L');//L
        findPath(row+1,col, 'D');//D

        lab[row, col] = ' ';
        result.Pop();
        path.RemoveAt(path.Count - 1);
        
        }
        if (lab[row, col] != ' ')
        {
            return;
        }  //zapisvame go v spisuka
        //  lab[row,col]='s';
        
    }

    private static void PrintPath(int finalRow, int finalCol)
    {
        Console.Write("Found the exit: ");
        foreach(var value in result)
        {
            Console.Write(value);
        }
        Console.WriteLine();
        
    }
        
    private static bool isInRange(int row, int col)
    {
        bool RolInRange = row >= 0 && row < lab.GetLongLength(0);
        bool ColInRange = col >= 0 && col < lab.GetLength(1);
        return RolInRange && ColInRange;
    }

}