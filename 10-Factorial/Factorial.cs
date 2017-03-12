using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;


class Factorial
{
    static void Main()
    {
        int[] array = new int[100];
        for (int i = 0; i < 100; i++)
        {
            array[i] = i + 1;
            Console.WriteLine(Fact(array[i]));
        }
    }
    static BigInteger Fact(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Fact(n - 1);
        }
    }
}

