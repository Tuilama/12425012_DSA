using System;

public class Chuong3
{
    public static void Run()
    {
        Console.WriteLine("=== CHƯƠNG 3 - BÀI 1 ===");
        Bai1();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 2 ===");
        Bai2();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 3 ===");
        Bai3();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 4 ===");
        Bai4();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 5 ===");
        Bai5();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 6 ===");
        Bai6();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 7 ===");
        Bai7();

        Console.WriteLine("\n=== CHƯƠNG 3 - BÀI 8 ===");
        Bai8();
    }

    public static void Bai1()
    {
        Console.Write("Nhập n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"S({n}) = {TinhS1(n)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static int TinhS1(int n)
    {
        if (n <= 1) return 1;
        return TinhS1(n - 1) + n;
    }

    public static void Bai2()
    {
        Console.Write("Nhập n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"S({n}) = {TinhS2(n)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static int TinhS2(int n)
    {
        if (n <= 1) return 1;
        return TinhS2(n - 1) + n * n;
    }

    public static void Bai3()
    {
        Console.Write("Nhập n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"S({n}) = {TinhS3(n):F4}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static double TinhS3(int n)
    {
        if (n <= 1) return 1.0;
        return TinhS3(n - 1) + 1.0 / n;
    }

    public static void Bai4()
    {
        Console.Write("Nhập cơ sở x: ");
        if (double.TryParse(Console.ReadLine(), out double x))
        {
            Console.Write("Nhập số mũ n: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine($"{x}^{n} = {TinhS4(x, n)}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập số mũ nguyên hợp lệ!");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập cơ sở hợp lệ!");
        }
    }

    private static double TinhS4(double x, int n)
    {
        if (n < 0) return 1.0 / LuyThua(x, -n);
        return LuyThua(x, n);
    }

    private static double LuyThua(double x, int n)
    {
        if (n == 0) return 1;
        return LuyThua(x, n - 1) * x;
    }

    public static void Bai5()
    {
        Console.Write("Nhập số nguyên dương n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"Ước số lẻ lớn nhất của {n} là: {UocLeMax(n)}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static int UocLeMax(int n)
    {
        if (n % 2 == 1) return n;
        return UocLeMax(n / 2);
    }

    public static void Bai6()
    {
        Console.Write("Nhập a: ");
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            Console.Write("Nhập b: ");
            if (int.TryParse(Console.ReadLine(), out int b) && b != 0)
            {
                Console.WriteLine($"UCLN({a}, {b}) = {UCLN(a, b)}");
            }
            else
            {
                Console.WriteLine("Vui lòng nhập b khác 0 hợp lệ!");
            }
        }
        else
        {
            Console.WriteLine("Vui lòng nhập a hợp lệ!");
        }
    }

    private static int UCLN(int a, int b)
    {
        if (a % b == 0) return b;
        return UCLN(b, a % b);
    }

    public static void Bai7()
    {
        Console.Write("Nhập n: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            int absN = Math.Abs(n);
            Console.WriteLine($"Số chữ số của {n} là: {(absN == 0 ? 1 : SoChuSo(absN))}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên hợp lệ!");
        }
    }

    private static int SoChuSo(int n)
    {
        if (n == 0) return 0;
        return SoChuSo(n / 10) + 1;
    }

    public static void Bai8()
    {
        Console.Write("Nhập n: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
        {
            Console.WriteLine($"S({n}) = {TinhS8(n):F4}");
        }
        else
        {
            Console.WriteLine("Vui lòng nhập số nguyên dương hợp lệ!");
        }
    }

    private static double Can(int i, int n)
    {
        if (i == n) return Math.Sqrt(n);
        return Math.Sqrt(i + Can(i + 1, n));
    }

    private static double TinhS8(int n)
    {
        return Can(1, n);
    }
}