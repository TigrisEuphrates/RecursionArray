using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static public void ShowArray(int[,] array, int i2=0)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i,i2]+"  ");
            }
            Console.WriteLine();
            i2++;
            
            if (i2>=(array.GetLength(1)-1))
            {
                return;
            }

            ShowArray(array, i2);
        }

        static void Main(string[] args)
        {
            int[,] arr = new int[8, 12];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int i2 = 0; i2 < arr.GetLength(1); i2++)
                {
                    arr[i, i2] = rand.Next(0, 20);
                }
            }
            ShowArray(arr);
        }
    }
}
