using System;

class LargestPrimeFactor
{
    static void Main()
    {
        long n = 600851475143;

        long maxPrime = 0;

        long i = 2;

        while (i<=n)
        {
            while (n%i==0)
            {
                n /= i;
                maxPrime = i;
            }
            i++;
        }

        Console.WriteLine(maxPrime);
    }
}
