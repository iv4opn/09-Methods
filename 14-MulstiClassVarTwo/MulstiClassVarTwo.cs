using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MulstiClassVarTwo
{
    static void Main()
    {

        Console.WriteLine("Enter number of elements:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Enter elements:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        
        Console.Write("Minimum= "+GetMin(array)+"\n");
        Console.Write("Maximum= " + GetMax(array)+"\n");
        Console.Write("Sum= " + GetSum(array)+"\n");
        Console.Write("Average= " +GetArithmeticMean(array)+"\n");
        Console.Write("Product= " + GetProduct(array)+"\n");
    }
    static decimal GetArithmeticMean(params int[] array)
    {
        int aritmethicMean = 0;
        if (array.Length > 0)
        {
            for (int i = 0; i < array.Length; i++)
            {
                aritmethicMean += array[i];

            }
        }
        else
        {
            Console.WriteLine("The array is empty!"); return 0;
        }

        return (decimal)aritmethicMean / (decimal)array.Length;
    }
    static int GetMax(params int[] array)
    {
        int max = array.Max();
        return max;
    }
    static int GetMin(params int[] array)
    {
        int min = array.Min();
        return min;
    }
    static int GetSum(params int[] array)
    {
        int sum = array.Sum();
        return sum;
    }
    static int GetProduct(params int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        if (array.Length > 0)
        {
            return product;
        }
        return 0;
    }

}

