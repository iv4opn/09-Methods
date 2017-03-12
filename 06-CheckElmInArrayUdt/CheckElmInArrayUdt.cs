using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CheckElmInArrayUdt
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        int size = int.Parse(Console.ReadLine());       
        int[] array = new int[size];
        Random rnd = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 100);
        }

        CheckArrayElement(array);
        Console.WriteLine();
        Console.WriteLine("Elements of array are:");
        PrintArray(array);
    }

    static void CheckArrayElement(int[] array)
    {
        bool flag = false;
        
        for (int i = 1; i < array.Length-1; i++)
		{
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {

                Console.WriteLine("The found index is: [{0}] = {1} ",i,array[i]);
                flag = true;
                break;
            }
        }
        if (flag==false)
        {
            Console.WriteLine("-1");
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

