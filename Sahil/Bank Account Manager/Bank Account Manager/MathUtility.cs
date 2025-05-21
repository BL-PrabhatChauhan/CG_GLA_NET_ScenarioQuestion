using System;

class MathUtility
{
    public static long Factorial(int n)
    {
        if (n < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
        long result = 1;
        for (int i = 2; i <= n; i++) result *= i;
        return result;
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    public static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    public static int Fibonacci(int n)
    {
        if (n < 0) throw new ArgumentException("Fibonacci is not defined for negative numbers.");
        if (n == 0) return 0;
        if (n == 1) return 1;

        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }
        return b;
    }
}
