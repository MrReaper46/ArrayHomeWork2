using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayHomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number of rows: ");
            int RowsNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Input number of columns: ");
            int ColsNumber = Int32.Parse(Console.ReadLine());
            
            int[,] ArrOfValue = new int[ColsNumber, RowsNumber];
            
            int MaxValue = 0;
            for (int i =0; i < ArrOfValue.GetLength(0);i++)
            {
                for (int j =0; j< ArrOfValue.GetLength(1); j++)
                {
                    Console.WriteLine($"Input Value: ");
                    ArrOfValue[i, j] = Int32.Parse(Console.ReadLine());
                    if (ArrOfValue[i, j] >= MaxValue)
                    {
                        MaxValue = ArrOfValue[i,j];
                    }
                    else { continue; }
                }
            }
            Console.WriteLine($"Max Value is: {MaxValue}");
        }
    }
}
