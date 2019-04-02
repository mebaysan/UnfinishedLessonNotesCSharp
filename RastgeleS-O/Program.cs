using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random random = new Random();
            string[,] harf = new string[15, 15];
            for (int i = 0; i <harf.GetUpperBound(0); i++){
                for(int j = 0; j <harf.GetUpperBound(1); j++)
                {
                    if (random.Next(0, 2) == 0)
                    {
                        harf[i,j] = "S";
                        Console.Write(harf[i, j]);
                    }
                    else
                    {
                        harf[i, j] = "O";
                        Console.Write(harf[i, j]);
                    }
                }
                Console.WriteLine();
            }
            Console.Read();
        }

        
    }
}
