using System;

class SmallestMultiple
{
    static void Main()
    {
        int num = 2520;

        int count = 0;

        while (count < 19)
        {
            for (int i = 2; i <= 20; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }

            if (count < 19)
            {
                count = 0;
                num+=10;
            }


        }

        Console.WriteLine(num);
    }
}
