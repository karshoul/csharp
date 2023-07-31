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
            // + - * / %
            // float a = 5;
            // int b = 4;
            // float kq = 6 / (2+3) * 2; 

            // Console.WriteLine(kq);

            // Console.WriteLine("a + b = {0}",a+b);
            // Console.WriteLine("a - b = {0}",a-b);
            // Console.WriteLine("a * b = {0}",a*b);
            // Console.WriteLine("a / b = {0}",a/b);
            // Console.WriteLine("a % b = {0}",a%b);

            // Toán tử Gán: = ; += ; -= ; /= ; %= \ ++ --
            // += : cộng thêm một giá trị bất kì vào biến
            // ++ : cộng thêm một giá trị, -- tương tự vậy (++x ưu tiên trước; x++ ưu tiên sau)
            // -= : trừ bớt đi giá trị 
            // Còn lại tương tụ vậy
            int x;
            x = 10;

            int z = 2 * ++x;
            Console.WriteLine(x);
            Console.WriteLine(z);

        }
    }
}