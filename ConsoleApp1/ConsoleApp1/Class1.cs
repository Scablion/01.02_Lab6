using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Class1
    {
        public static int minNum(int [,] mas)
        {
            int min = 0, K = 1;
            for (int i = 11; i >= 0; i--)
            {
                for (int k = 11 - i; k <= i; k++)
                {
                    if (K == 1)
                    {
                        min = mas[i, k];
                        K++;
                    }
                    else
                    {
                        if (min > mas[i, k])
                        {
                            min = mas[i, k];
                        }
                    }
                }
            }
            return min;
        } 

        public static int[] ArrayW(int[,] mas)
        {
            
            int g = 0,c = 0;
            for (int i = 11; i >= 0; i--)
            {
                for (int k = 11 - i; k <= i; k++)
                {
                    if (mas[i, k] < 7)
                    {
                        g++;
                    }
                }
            }
            int[] W = new int [g];
            for (int i = 11; i >= 0; i--)
            {
                for (int k = 11 - i; k <= i; k++)
                {
                    if (mas[i, k] < 7)
                    {
                        W[c] += mas[i, k];
                        c++;
                    }
                }
            }
            return W;
        }

        public static int[] ArrayN(int[,] mas)
        {

            int g = 0, c = 0;
            int[] W = new int[6];
            for (int i = 11; i >= 6; i--)
            {
                for (int k = 11 - i; k <= i; k++)
                {
                    if (mas[i, k] < 0)
                    {
                        g++;
                    }
                }
                W[c] = g;
                g = 0;
                c++;
            }
            return W;
        }



    }
}
