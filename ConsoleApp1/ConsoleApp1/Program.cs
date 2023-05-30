using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.Class1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mas = new int[12, 12];
            for (int i = 0; i < 12; i++)
            {
                for (int k = 0; k < 12; k++)
                {

                    mas[i, k] =/* rnd.Next(-100, 100)*/ 0;
                }
            }

            for (int i = 11; i >= 0; i--)
            {
                for (int k = 11 - i; k <= i; k++)
                {
                    mas[i, k] = 1;
                }
            }

            for (int i = 0; i < 12; i++)
            {
                for (int k = 0; k < 12; k++)
                {
                    if (mas[i, k] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(mas[i, k] + "\t");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                        Console.Write(mas[i, k] + "\t");

                }
                Console.WriteLine();
            }

            for (int i = 0; i < 12; i++)
            {
                for (int k = 0; k < 12; k++)
                {

                    mas[i, k] = rnd.Next(-100, 100);
                }
            }

            Console.WriteLine("{");
            for (int i = 0; i < 12; i++)
            {
                Console.Write("{");
                for (int k = 0; k < 12; k++)
                {
                    Console.Write(mas[i, k] + ",\t");
                }
                Console.WriteLine("},");
            }
            Console.WriteLine("}");
            //Zadanie1
            Console.WriteLine("Minimal value = " + minNum(mas));
            Console.WriteLine();

            //Zadanie2
            int[] K = ArrayW(mas);
            for (int i = 0; i < K.Length; i++)
            {
                Console.Write($"{K[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Zadanie 3
            Console.Write("Кол-во отриц. чисел в строках: ");
            int[] N = ArrayN(mas);
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write($"{N[i]}, ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Zadanie 4
            int s = SummUp(mas);
            Console.WriteLine($"Summ = {s}");
        }
    }
}
