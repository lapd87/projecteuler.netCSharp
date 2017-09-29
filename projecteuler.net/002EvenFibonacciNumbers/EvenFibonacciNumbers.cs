using System;

class EvenFibonacciNumbers
{
    static void Main()
    {
        int sum = 2;

        int firstNum = 1;
        int secondNum = 2;

        while (secondNum<4000000)
        {
            int newNum = firstNum + secondNum;

            if (newNum%2==0)
            {
                sum += newNum;
            }

            firstNum = secondNum;
            secondNum = newNum;
        }

        Console.WriteLine(sum);
    }
}
