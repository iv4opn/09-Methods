using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrintName
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string myName = Console.ReadLine();
        PrintMyName(myName);
    }

    static void PrintMyName(string name)
    {
        Console.WriteLine("Hello {0} !", name);
    }

}

