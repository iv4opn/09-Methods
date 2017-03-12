using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Polynomials
{
    
        public static void Main()
        {
            int[] polynomOne = EnterPolynom();
            int[] polynomTwo = EnterPolynom();

            int[] resultAddition = PolynomOperation(polynomOne, polynomTwo, "Add");
            int[] resultSubstraction = PolynomOperation(polynomOne, polynomTwo, "Substract");
            int[] resultMulty = PolynomOperation(polynomOne, polynomTwo, "Multiply");

            PrintPolynom(resultAddition);

            PrintPolynom(resultSubstraction);

            PrintPolynom(resultMulty);
        }

        public static int[] EnterPolynom()
        {
            Console.Write("Enter highest power of x : ");
            int n = int.Parse(Console.ReadLine());

            int[] answer = new int[n + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                Console.Write("Enter the coeficient before x^{0} : ", i);
                answer[i] = int.Parse(Console.ReadLine());
            }
            return answer;
        }

        public static void PrintPolynom(int[] polynom)
        {
            for (int i = polynom.Length - 1; i > 0; i--)
            {
                if (polynom[i] != 0)
                {
                    Console.Write("({0})x^{1} + ", polynom[i], i);
                }
            }
            Console.WriteLine("{0}", polynom[0]);
        }

        public static int[] PolynomOperation(int[] polynomOne, int[] polynomTwo, string operation)
        {
            int[] answer;

            if (polynomOne.Length >= polynomTwo.Length)
            {
                answer = new int[polynomOne.Length];
                Array.Copy(polynomOne, answer, polynomOne.Length);
            }
            else
            {
                answer = new int[polynomTwo.Length];
                Array.Copy(polynomTwo, answer, polynomTwo.Length);
            }

            int operationsToBePerformed = Math.Min(polynomOne.Length, polynomTwo.Length);

            if (operation == "Add")
            {
                for (int i = 0; i < operationsToBePerformed; i++)
                {
                    answer[i] = polynomOne[i] + polynomTwo[i];
                }
            }
            else if (operation == "Substract")
            {
                for (int i = 0; i < operationsToBePerformed; i++)
                {
                    answer[i] = polynomOne[i] - polynomTwo[i];
                }
            }
            else if (operation == "Multiply")
            {
                for (int i = 0; i < operationsToBePerformed; i++)
                {
                    answer[i] = polynomOne[i] * polynomTwo[i];
                }
            }
            else
            {
                Console.WriteLine("Wrong operation !");
                Environment.Exit(0);
            }

            return answer;


        }
    
}

