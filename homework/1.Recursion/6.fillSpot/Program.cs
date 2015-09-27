using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int count = 0;
    static char[,] lab =
    { 
        {'*', '1', ' ', '*', '2', ' ', ' ', '*', '3', ' '},
        {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
        {'*', ' ', ' ', '*', '3', ' ', ' ', '*', ' ', ' '},
        {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '}
    };
    static void Main(string[] args)
    {
        loopRec(0,0);
    }
    private static void loopRec(int row, int col)
    {
        if (row == lab.GetLength(0))
        {  
        }
        else if (!isInRange(row, col))
        {
            loopRec(row + 1, 0);
        }
        else
        {
            if ((lab[row, col] != ' ') && (lab[row, col] != 'X') && (lab[row, col] != '*'))
            {
                Console.Write("Area #{0} at ({1},{2}) size:",lab[row, col], row, col);
                lab[row, col]=' ';
                findField(row, col);
                Console.WriteLine(count);
                count=0;
            }
            loopRec(row, col + 1);
        }


    }
    static void findField(int row, int col)
    {
        if(!isInRange(row, col))
        {
            return;
        }
        if(lab[row, col]!=' ')
        {
            return;
        }
        if(lab[row, col]==' ')
        {
            lab[row, col]='X';
            count++;

            findField(row,col+1);//R
            findField(row-1,col);//D
            findField(row,col-1);//L
            findField(row+1, col);//U

        }
    }

    private static bool isInRange(int row, int col)
    {
        bool rowLength = row >= 0 && row < lab.GetLength(0);
        bool colLength = col >= 0 && col < lab.GetLength(1);
        return rowLength && colLength;
    }
}