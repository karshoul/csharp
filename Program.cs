using System;

namespace CS_hello_world
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        static void Main(string[] args)
        {
            bool kq;
            // Toán tử so sánh: == ; > ; < ; >= ; <= ; !=

            // int a = 5;
            // int b = 6;

            // kq = a == b;

            // Console.WriteLine("a == b = {0}",kq);
            // // $ chèn vào để có thể thêm biểu thức vào câu lệnh
            // Console.WriteLine($"a != b = {a != b}");
            // Console.WriteLine($"a > b = {a > b}");
            // Console.WriteLine($"a >= b = {a >= b}");
            // Console.WriteLine($"a < b = {a < b}");
            // Console.WriteLine($"a <= b = {a <= b}");

            // Toán tử logic: && || !
            bool a = false;
            bool b = false;
            kq = a || b;

            Console.WriteLine(kq);  

        }
    }
}