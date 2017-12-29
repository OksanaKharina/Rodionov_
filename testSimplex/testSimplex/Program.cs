using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testSimplex
{
    class Program
    {
        static void Main(string[] args)
        {
             //Console.Write("Введите размер матрицы (строки)n: ");
             //int size = int.Parse(Console.ReadLine());

             //Console.Write("Введите размер матрицы (столбцы)m: ");
             //int size1 = int.Parse(Console.ReadLine());

             //Console.WriteLine("Введите элементы матрицы: ");
             //int[,] table = new int[size, size1];

             //for (int i = 0; i < table.GetLength(0); i++)
             //{
             //    string enterString = Console.ReadLine();
             //    string[] massiveString = enterString.Split(new Char[] { ' ' });
             //    for (int j = 0; j < massiveString.Length; j++)
             //    {
             //        table[i, j] = int.Parse(massiveString[j]);
             //    }
             //}
             int[,] table = { { 16, 3, 1, 1, 0, 0},
                              { 4, 1, 0, 0, 1, 0},
                              { 5, 0, 1, 0, 0, 1},
                              { 0, 1, 4, 0, 0, 0} };
            Console.WriteLine("таблица:");
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write(table[i, j] + " ");
                Console.WriteLine();
            }

            int[] result = new int[2];
            int[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);

            Console.WriteLine("Решенная симплекс-таблица:");
            for (int i = 0; i < table_result.GetLength(0); i++)
            {
                for (int j = 0; j < table_result.GetLength(1); j++)
                    Console.Write(table_result[i, j] + " ");
                Console.WriteLine();
            }       
           
             Console.WriteLine();
             Console.WriteLine("Решение:");
             Console.WriteLine("X[1] = " + result[0]);
             Console.WriteLine("X[2] = " + result[1]);
            
            Console.ReadLine();
        }
    }
}
