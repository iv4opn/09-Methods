using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckElmntInArray
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter element position:");
        int position = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0,100);
        }

        CheckArrayElement(array, position);
        Console.WriteLine();
        Console.WriteLine("Elements of array are:");
        PrintArray(array);
    }

    static void CheckArrayElement(int[] array,int position)
    {
        
        if (position>0 && position<array.Length-1)
        {
            if (array[position] > array[position - 1] && array[position] > array[position +1])
            {

                Console.WriteLine("The element {0} of postiion {1} is bigger than his neighbors: {2} < {0} > {3}", array[position], position, array[position - 1], array[position+1]);
            }
            else
            {
                Console.WriteLine("The element does not satisfy the condition.");
            }
        }
        else
        {
            Console.WriteLine("You must enter number bigger than zero and smaler than array lenght ! ");
        }
    
    }
    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}