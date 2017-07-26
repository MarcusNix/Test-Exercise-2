using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKaspersky2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 i = 0, j = 0, c = 0;
            Console.WriteLine("Введите искомое число Х:");
            Int64 M = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите длину массива:");
            Int64 COUNT = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Введите максимально возможное число массива:");
            Int64 r = Convert.ToInt64(Console.ReadLine());
            Int64[] mas = new Int64[COUNT];
            Int64[,] pairs = new Int64[COUNT * (COUNT - 1), 4];
            Random rnd = new Random();
            Console.WriteLine("Массив:");
            for (i = 0; i < COUNT; i++)
            {
                mas[i] = rnd.Next((Int32)(r + 1));
                Console.Write(mas[i] + " ");
            }
            for (i = 0; i < COUNT - 1; i++)
            {
                for (j = i + 1; j < COUNT; j++)
                {
                    if (mas[i] + mas[j] == M)
                    {
                        pairs[c, 0] = i;
                        pairs[c, 1] = j;
                        pairs[c, 2] = mas[i];
                        pairs[c, 3] = mas[j];
                        c++;
                    }
                }
            }
            Console.WriteLine("Формат выводимых данных:");
            Console.WriteLine("индекс первого числа(i) | индекс второго числа(j) | первое число(ai) | второе число(aj)");
            for (i = 0; i < c; i++)
            {
                Console.WriteLine("{0} | {1} | {2} | {3}", pairs[i, 0], pairs[i, 1], pairs[i, 2], pairs[i, 3]);
            }
            Console.Read();
        }
    }
}
