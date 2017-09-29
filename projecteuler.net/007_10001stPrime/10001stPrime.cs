using System;

class _10001stPrime
{
    static void Main()
    {
        long num = 13;
        int count = 6;

        while (count <= 10001)
        {
            int i = 2;

            while (i <= Math.Sqrt(num))
            {
                if (num % i != 0)
                {
                    i++;
                    continue;
                }
                num += 2;
                i = 2;
            }
            num += 2;
            count++;
        }
        num -= 2;
        Console.WriteLine(num);
    }
}
