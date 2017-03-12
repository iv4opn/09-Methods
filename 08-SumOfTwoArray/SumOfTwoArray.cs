using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class SumOfTwoArray
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        ulong first = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number");
        ulong second = ulong.Parse(Console.ReadLine());

        Console.Write("The result is = ");
        AddTwoArrayS(first,second);

    }
    static void AddTwoArrayS(ulong firstNum, ulong secondNum)
    {
        
        string firstStrNum = Convert.ToString(firstNum);
        string secondStrNum = Convert.ToString(secondNum);
        int max = (int)Math.Max(firstStrNum.Length, secondStrNum.Length);
        byte[] firstArray = new byte[max];
        byte[] secondArray = new byte[max];        
        int sumCheck = 0;
        byte carry = 0;
        string finalSum = "";
        int[] sumArray=new int[max];

        for (int i = 0, j=firstStrNum.Length-1; i < firstStrNum.Length; i++,j--)
        {
            firstArray[j] = (byte)Char.GetNumericValue(firstStrNum[i]);
        }
        for (int i = 0, j = secondStrNum.Length - 1; i < secondStrNum.Length; i++, j--)
        {
            secondArray[j] = (byte)Char.GetNumericValue(secondStrNum[i]);
        }

        for (int i =0; i < max; i++)
        {
            sumCheck=firstArray[i]+secondArray[i]+carry;
            if (sumCheck>9)
            {
                carry = 1;
                sumArray[i] = sumCheck%10;
            }
            else
            {
                carry = 0;
                sumArray[i] = sumCheck;
            }

            
        }
        Array.Reverse(sumArray);
        for (int i = 0; i < sumArray.Length; i++)
        {
            finalSum += Convert.ToString(sumArray[i]);
        }
        Console.WriteLine(finalSum);
    }


}
