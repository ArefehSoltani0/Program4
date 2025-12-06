using System;

class Program
{
    // متد محاسبه فاکتوریل (برای اعداد غیرمنفی)
    static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("فاکتوریل فقط برای اعداد غیرمنفی تعریف شده است.");

        if (n == 0 || n == 1)
            return 1;

        long result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("لطفاً 6 عدد صحیح غیرمنفی وارد کنید:");

        for (int i = 1; i <= 6; i++)
        {
            Console.Write($"عدد {i}: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                try
                {
                    long fact = Factorial(number);
                    Console.WriteLine($"فاکتوریل عدد {number} = {fact}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"خطا: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("ورودی نامعتبر است. لطفاً یک عدد صحیح وارد کنید.");
                i--; // تکرار دریافت برای همان شماره
            }
        }
        Console.ReadKey();
    }
}