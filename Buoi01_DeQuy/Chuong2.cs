using System;
using System.Diagnostics;

public class Chuong2
{
    public static void Run()
    {
        Console.WriteLine("=== CHƯƠNG 2 - BÀI 1 ===");
        Bai1();

        Console.WriteLine("\n=== CHƯƠNG 2 - BÀI 2 ===");
        Bai2();

        Console.WriteLine("\n=== CHƯƠNG 2 - BÀI 3 ===");
        Bai3();

        Console.WriteLine("\n=== CHƯƠNG 2 - BÀI 4 ===");
        Bai4();

        Console.WriteLine("\n=== CHƯƠNG 2 - BÀI 5 ===");
        Bai5();

        Console.WriteLine("\n=== CHƯƠNG 2 - BÀI 6 ===");
        Bai6();
    }

    public static void Bai1()
    {
        Console.Write("Nhập số lượng đĩa n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Stopwatch sw = Stopwatch.StartNew();
            ThapHaNoi(n, 'A', 'B', 'C');
            sw.Stop();
            Console.WriteLine($"Thời gian thực thi: {sw.Elapsed.TotalMilliseconds} ms");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static void ThapHaNoi(int n, char nguon, char trungGian, char dich)
    {
        if (n == 1) return;
        ThapHaNoi(n - 1, nguon, dich, trungGian);
        ThapHaNoi(n - 1, trungGian, nguon, dich);
    }

    public static void Bai2()
    {
        int[] arr = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
        int key = 15;
        int result = BinarySearchDeQuy(arr, 0, arr.Length - 1, key);
        Console.WriteLine(result != -1 ? $"Tìm thấy tại vị trí: {result}" : "Không tìm thấy");
    }

    private static int BinarySearchDeQuy(int[] arr, int left, int right, int key)
    {
        if (left > right) return -1;
        int mid = left + (right - left) / 2;
        if (arr[mid] == key) return mid;
        if (arr[mid] > key) return BinarySearchDeQuy(arr, left, mid - 1, key);
        return BinarySearchDeQuy(arr, mid + 1, right, key);
    }

    public static void Bai3()
    {
        Console.Write("Nhập số nguyên cần kiểm tra: ");
        if (long.TryParse(Console.ReadLine(), out long n))
        {
            Console.WriteLine(IsPrime(n) ? $"{n} là số nguyên tố." : $"{n} không phải số nguyên tố.");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
        }
    }

    private static bool IsPrime(long n)
    {
        if (n < 2) return false;
        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void Bai4()
    {
        Console.Write("Nhập n để liệt kê số hoàn hảo nhỏ hơn n: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.Write($"Các số hoàn hảo nhỏ hơn {n}: ");
            for (int i = 1; i < n; i++)
            {
                if (IsPerfect(i)) Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên hợp lệ!");
        }
    }

    private static bool IsPerfect(int n)
    {
        if (n < 2) return false;
        int sum = 1;
        for (long i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                sum += (int)i;
                if (i != n / i) sum += (int)(n / i);
            }
        }
        return sum == n;
    }

    public static void Bai5()
    {
        Console.Write("Nhập vị trí n của số Fibonacci cần tìm: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            Console.WriteLine($"Số Fibonacci thứ {n} là: {FiboLap(n)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập một số nguyên không âm hợp lệ!");
        }
    }

    private static long FiboLap(int n)
    {
        if (n <= 2) return n == 0 ? 0 : 1;
        long f1 = 1, f2 = 1, fn = 1;
        for (int i = 3; i <= n; i++)
        {
            fn = f1 + f2;
            f1 = f2;
            f2 = fn;
        }
        return fn;
    }

    public static void Bai6()
    {
        double[] arr = { 3.5, 1.2, 9.8, 5.4, 2.1 };
        BubbleSort(arr);
        Console.WriteLine("Dãy sau khi sắp xếp:");
        foreach (var x in arr) Console.Write(x + "  ");
        Console.WriteLine();
    }

    private static void BubbleSort(double[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    double temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}