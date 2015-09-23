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
        //{' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        //{' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        //{' ', ' ', ' ', '*', ' ', ' ', ' ', '*', ' '},
        //{' ', ' ', ' ',' ' , '*', ' ', '*', ' ', ' '}

        {'*', '1', ' ', '*', '2', ' ', ' ', '*', '3', ' '},
        {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '},
        {'*', ' ', ' ', '*', '*', '*', '*', '*', ' ', ' '},
        {'*', ' ', ' ', '*', '3', ' ', ' ', '*', ' ', ' '},
        {'*', ' ', ' ', '*', ' ', ' ', ' ', '*', ' ', ' '}

    };
    static void Main(string[] args)
    {
        for (int i = 0; i < lab.GetLength(0); i++)
        {
            for (int j = 0; j < lab.GetLength(1);j++ )
            {
                if ((lab[i, j] != ' ') && (lab[i, j] != '*') &&(lab[i, j]!='X'))
                {
                    lab[i, j] = ' ';
                    findField(i, j);
                    Console.WriteLine(count);
                    count = 0;
                }
            }
        }
        for (int i = 0; i < lab.GetLength(0); i++)
        {
            for (int j = 0; j < lab.GetLength(1); j++)
            {
                Console.Write(lab[i,j]);
            }
            Console.WriteLine();
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