using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad120
{
    class Program
    {
        // функция нахождения мин из двух значений
        static int min (int a1, int a2)
        {
            if (a1 > a2) return a2;
            else return a1;
        }
        // ---------------------------------------
        static void Main(string[] args)
        {
            int i, j, n = 3, m = 4;
            
            int[,] A = new int [3, 4] { { 1, 1, 1, 1   }, { 5, 2, 2, 100 }, { 9, 4, 2, 1 }  };
            
            // Выводим данный массив
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    
                    Console.Write("{0}\t", A[i,j]);
                }
                Console.WriteLine(); 
            }
            Console.ReadKey();
            for (j = 1; j < m; j++)
            {
                A[0,j] += A[0,j - 1];
                
            }
            for (i = 1; i < n; i++)
            {
                A[i, 0] += A[i - 1, 0];
                
            }
            for (i = 1; i < n; i++)
            {
                for (j = 1; j < m; j++)
                {
                    A[i, j] += min(A[i - 1, j], A[i, j - 1]);
                    
                }
            }
            Console.Write(A[n - 1, m - 1]);
            Console.ReadKey();


        }
    }
}
