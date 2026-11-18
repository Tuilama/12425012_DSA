using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int chon;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Chạy bài tập Chương 1");
            Console.WriteLine("2. Chạy bài tập Chương 2");
            Console.WriteLine("3. Chạy bài tập Chương 3");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập lựa chọn của bạn: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("Nhập số từ 0 đến 3 Bấm phím bất kỳ để nhập lại");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine();
            switch (chon)
            {
                case 1:
                    Console.WriteLine(" BẮT ĐẦU CHẠY CHƯƠNG 1 ");
                    Chuong1.Run();
                    break;
                case 2:
                    Console.WriteLine(" BẮT ĐẦU CHẠY CHƯƠNG 2 ");
                    Chuong2.Run();
                    break;
                case 3:
                    Console.WriteLine(" BẮT ĐẦU CHẠY CHƯƠNG 3 ");
                    Chuong3.Run();
                    break;
                case 0:
                    Console.WriteLine(" Tắt chương trình");
                    break;
                default:
                    Console.WriteLine("Không có lựa chọn này hãy chọn lại.");
                    break;
            }

            if (chon != 0)
            {
                Console.Write("Bấm phím bất kỳ để quay lại menu chính");
                Console.ReadKey();
            }

        } while (chon != 0);
    }
}