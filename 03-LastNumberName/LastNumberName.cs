using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastNumberName
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        string number = Console.ReadLine();
        NumName(number);
    }
    static void NumName(string number)
    {
        int lastDigit =(int)Char.GetNumericValue(number.Last());

        switch (lastDigit)
        {
            case 0: Console.WriteLine("The name of last digit on number {0} is 'NULL'. ", number); break;
            case 1: Console.WriteLine("The name of last digit on number {0} is 'ONE'. ", number); break;
            case 2: Console.WriteLine("The name of last digit on number {0} is 'TWO'. ", number); break;
            case 3: Console.WriteLine("The name of last digit on number {0} is 'THREE'. ", number); break;
            case 4: Console.WriteLine("The name of last digit on number {0} is 'FOUR'. ", number); break;
            case 5: Console.WriteLine("The name of last digit on number {0} is 'FIVE'. ", number); break;
            case 6: Console.WriteLine("The name of last digit on number {0} is 'SIX'. ", number); break;
            case 7: Console.WriteLine("The name of last digit on number {0} is 'SEVEN'. ", number); break;
            case 8: Console.WriteLine("The name of last digit on number {0} is 'EIGHT'. ", number); break;
            case 9: Console.WriteLine("The name of last digit on number {0} is 'NINE'. ", number); break;

        }

    }

}

