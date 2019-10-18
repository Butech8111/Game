using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krestiki_nol
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, i1, j1, i2, j2;
            int [,] aArr = new int [3, 3];
            // Инициализируем данный массив
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    aArr[i, j] = 8;
                    Console.Write("{0}\t", aArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            Console.WriteLine("Первый игрок: Поставте 1 в любое поле, где нет 1");
            Console.WriteLine("Для этого выберети значение i,j");
            Console.WriteLine("i=");
            string si1 = Console.ReadLine();
            i1 = Convert.ToInt32(si1);
            Console.WriteLine("j=");
            string sj1 = Console.ReadLine();
            j1 = Convert.ToInt32(sj1);
            aArr[i1, j1] = 1;


            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.Write("{0}\t", aArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


            do
            {
                Console.WriteLine("Второй игрок: Поставте 0 в любое поле, где нет 0");
                Console.WriteLine("Для этого выберети значение i,j");
                Console.WriteLine("i=");
                string si2 = Console.ReadLine();
                i2 = Convert.ToInt32(si2);
                Console.WriteLine("j=");
                string sj2 = Console.ReadLine();
                j2 = Convert.ToInt32(sj2);
            }
            while (aArr[i1, j1] == aArr[i2, j2]);
            aArr[i2, j2] = 0;

            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    Console.Write("{0}\t", aArr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    }
}
