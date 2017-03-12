using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortSubArray
{
    static void Main()
    {
        Console.WriteLine("Enter size of array:");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter start index of subarray:");
        int startInd = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter end index of subarray:");
        int endInd = int.Parse(Console.ReadLine());
       
        int[] array = new int[size];
        Random rnd = new Random();

        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(0, 100);
        }

        Console.WriteLine();
        Console.WriteLine("The elements of array are:");
        PrintArray(array); Console.WriteLine();       
        Console.WriteLine("The elements of subarray are:");
        PrintSubArray(array, startInd, endInd);
        Console.WriteLine("The biggest number of subarray is= " + GetMaxElement(array, startInd, endInd)); Console.WriteLine();
        SortSubArr(array,startInd,endInd);
        
    }

    static int GetMaxElement(int [] array,int start, int end)
    {
        int maxElement=int.MinValue;
        if (start < end)
        {
            for (int i = start; i < end; i++)
            {
                if (array[i]>=maxElement)
                {
                    maxElement = array[i];
                }
            }
        }
        else
        {
            Console.WriteLine("Start index must be bigger than end index !");  return 0;
        }
        return maxElement;
    }
    static void PrintArray(int[] array)
    {
        
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
    static void SortSubArr(int[] array, int start, int end)
    {
        int[] secondArr=new int[end-start];
        for (int i = start; i < end-1; i++)
        {
            for (int j = i+1; j < end; j++)
            {
                if (array[i]>array[j])
                {
                    int helpVar = array[i];
                    array[i] = array[j];
                    array[j] = helpVar;
                }
            }
            
        }
        Console.WriteLine("Sorted in ascending order:");
        for (int i = start,j=secondArr.Length-1; i < end; i++,j--)
        {
            secondArr[j] = array[i];
            Console.Write(array[i] + " ");
            
        }
        Console.WriteLine();
        Console.WriteLine("Sorted in descending order:");
        for (int i = 0; i < secondArr.Length; i++)
        {
            Console.Write(secondArr[i] + " ");            
        }
        Console.WriteLine();

    }
    static void PrintSubArray(int[] array, int start, int end)
    {
        for (int i = start; i < end; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
   
}

