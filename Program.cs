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
            /*
            Kieu_du_lieu Ten_bien;
            *Ten_bien: 
                1. a...z A...Z
                2. 0...9
                3. _
                4. Không bắt đầu bằng số
            */
            // double so_pi;
            // so_pi = 3.14;

            // Console.Clear();

            // Console.Title = "Vi du su dung console";

            // Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Console.BackgroundColor = ConsoleColor.Cyan;

            // Console.WriteLine("Xin chao, chuong trinh nhap xuat du lieu console");

            // Console.ResetColor();

            // string hovaten;
            // Console.Write("Ho ten cua ban:");
            // hovaten = Console.ReadLine();

            // Console.WriteLine("Xin chao {0}",hovaten);

            // float a, b;
            // string sinput;

            // Console.WriteLine("Hay nhap tham so a:");
            // sinput = Console.ReadLine();

            // // Chuyển kiểu chuỗi sang số
            // a = float.Parse(sinput);

            // Console.WriteLine("Hay nhap tham so b:");
            // sinput = Console.ReadLine();
            // b = Convert.ToSingle(sinput);

            // Console.Write("So a = {0}, b = {1}",a, b);
            
            // const: hằng số không thể thay đổi giá trị

            const double pi = 3.14;
            const string web = "Thutu";

            Console.WriteLine(pi);
            Console.WriteLine(web);
        }
    }
}