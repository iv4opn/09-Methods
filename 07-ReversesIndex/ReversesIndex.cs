using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReversesIndex
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Reversed number is:");
        Console.WriteLine(ReverseDigits(n));
        
        
    }

    static int ReverseDigits(int number)
    {

        string newNum = "";
        string getString = Convert.ToString(number);
        for (int i = getString.Length - 1; i >= 0; i--)
        {
            newNum += getString[i];
        }
        return int.Parse(newNum);

    }

}
