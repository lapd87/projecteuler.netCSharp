using System;

class LargestPalindromeProduct
{
    static void Main()
    {
        int maxNum = 0;

        for (int i = 999; i >= 100; i--)
        {
            for (int j = i; j >= 100; j--)
            {
                int num = i * j;

                bool isPalindromic;

                if (num > 99999)
                {
                    isPalindromic = (num % 10) == (num / 100000) &&
                                    ((num / 10) % 10) == ((num / 10000) % 10) &&
                                    ((num / 100) % 10) == ((num / 1000) % 10);
                }
                else
                {
                    isPalindromic = (num % 10) == (num / 10000) &&
                                    ((num / 10) % 10) == ((num / 1000) % 10);
                }

                if (isPalindromic && num > maxNum)
                {
                    maxNum = num;
                }
            }
        }

        Console.WriteLine(maxNum);
    }
}
