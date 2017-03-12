using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NumCounter
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter searching number between 0-9:");
        int searchN = int.Parse(Console.ReadLine());
        int[] array=new int[size];
        Random rnd = new Random();
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0,9);
        }
        
        SearchNum(array,searchN);
        Console.WriteLine();
        Console.WriteLine("Elements of array are:");
        PrintArray(array);
    }

    static void SearchNum(int[] array, int num)
    {
        int count = 0;
        
        
        for (int i = 0; i < array.Length; i++)
        {
            if (num==array[i])
            {
                count++;
              
               
            } 

        }
        if (count!=0)
        {
            Console.WriteLine("The searching number {0} is appear in array {1} times.", num, count);
        }
        else
        {
            Console.WriteLine("The array doesn't have searching number !");
        }


    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
    }
}
