using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MultiFunctionalClass
{
    static void Main()
    {
        Console.Write("Press 1 - [Reverses the digit of a number]\nPress 2 - [Calculates the averages of a sequence of integers]\nPress 3 - [Solves a linear equation a*x+b=0]\n");

        ConsoleKeyInfo pressedKey = Console.ReadKey();
        
            switch (pressedKey.KeyChar)
            {
                case '1':
                    Console.Write("\nEnter number that you want to reverse: ");
                    int reverseNum = int.Parse(Console.ReadLine());
                    Console.Write("After reverse number is: " + ReverseDigits(reverseNum));Console.WriteLine(); break;
                case '2':
                    Console.WriteLine("\nEnter the number of integers: ");
                    int num = int.Parse(Console.ReadLine());
                    int[] array=new int[num];
                    Console.WriteLine("Enter {0} numbers:",num);
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("The averege of sequence is: " + GetArithmeticMean(array));
                    break;
                case '3':
                    Console.Write("\nEnter a: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.Write("Enter b: ");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("The result from linear equation {0}*x+{1}=0 is: {2}",a,b,GetLinearEquation(a,b));
                    break;
                default: Console.WriteLine("You must choose between:1, 2 or 3."); break;
            }

       
    }
    static decimal ReverseDigits(decimal number)
    {
        if (number<0)
        {
            number = -number;
        }

        string newNum = "";
        string getString = Convert.ToString(number);
        for (int i = getString.Length - 1; i >= 0; i--)
        {
            newNum += getString[i];
        }
        return decimal.Parse(newNum);

    }
    static decimal GetArithmeticMean(int[] array)
    {
       int aritmethicMean=0;
       if (array.Length>0)
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
    static int GetLinearEquation(int a, int b)
    {
        int x=int.MinValue;
        if (a!=0)
        {
            x = -b / a;
        }
        else
        {
            Console.WriteLine("'a' must be different from '0'.");
        }
        return x;

    }

}