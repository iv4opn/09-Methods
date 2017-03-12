using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxNumber
{
    static void Main()
    {
        Console.Write("Enter first number = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter third number = ");
        int c = int.Parse(Console.ReadLine());
                
        GetMax(a,(int)Math.Max(b,c));        

    }

    static void GetMax(int a, int b)
    {
        int max = a;
        if (b>max)
        {

            max = b; 
        }
        Console.WriteLine("The greatest number is: " + max);
        
    }
}

