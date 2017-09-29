using System;

class SumSquareDifference
{
    static void Main()
    {
        double sumSquares = 0;
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum += i;
            sumSquares += Math.Pow(i, 2);
        }

        double squareSum = Math.Pow(sum, 2);

        Console.WriteLine(Math.Abs(sumSquares - squareSum));
    }
}
