using System;

class Program
{
    static void Main()
    {
        // Khai báo biến để lưu trữ hai số a và b
        int a, b;

        a = 5;
        b = 6;
  
        int sum = a + b;
        Console.WriteLine($"Tổng của {a} và {b} là {sum}");

        // Dừng chương trình để người dùng có thể xem kết quả trước khi đóng cửa sổ console
        Console.ReadLine();
    }
}
