using System;
using System.Linq;

public class Chuong1
{
    public static void Run()
    {
        Console.WriteLine("=== CHƯƠNG 1 - BÀI 1 ===");
        Bai1();

        Console.WriteLine("\n=== CHƯƠNG 1 - BÀI 2 ===");
        Bai2();

        Console.WriteLine("\n=== CHƯƠNG 1 - BÀI 3 ===");
        Bai3();

        Console.WriteLine("\n=== CHƯƠNG 1 - BÀI 4 ===");
        Bai4();

        Console.WriteLine("\n=== CHƯƠNG 1 - BÀI 5 ===");
        Bai5();
    }

    public static void Bai1()
    {
        int[] arr = new int[1000];
        Random rand = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 1000);
        }

        int max = arr.Max();
        int min = arr.Min();

        Console.WriteLine($"Số lớn nhất (Max): {max}");
        Console.WriteLine($"Số nhỏ nhất (Min): {min}");
    }

    public static void Bai2()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }

    public static void Bai3()
    {
        Console.Write("Nhập vào một chuỗi: ");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);

        Console.WriteLine($"Chuỗi đảo ngược: {reversed}");
    }

    public static void Bai4()
    {
        int[] arr = new int[1000];
        Random rand = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(0, 1000);
        }

        Console.WriteLine("a. Mảng ban đầu:");
        Console.WriteLine(string.Join(" ", arr));

        Array.Sort(arr);

        Console.WriteLine("\nb. Mảng sau khi sắp xếp tăng dần:");
        Console.WriteLine(string.Join(" ", arr));
    }

    public static void Bai5()
    {
        Console.Write("Nhập n (n >= 0): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            long result = GetFibonacci(n);
            Console.WriteLine($"Số Fibonacci thứ {n} là: {result}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
        }
    }

    private static long GetFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        long a = 0, b = 1, c = 0;
        for (int i = 2; i <= n; i++)
        {
            c = a + b;
            a = b;
            b = c;
        }
        return c;
    }
}