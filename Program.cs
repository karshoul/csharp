using System;
using System.Linq;

namespace CS_hello_world
{
    class Program
    {   
            /*--------Cú pháp khai báo một phương thức cơ bản---------
                    <Access Modifiers> <return type> <name_method>(<parameters>)
                {
                    // Các câu lệnh trong phương thức
                }
            */
        
            // Đây là hàm Main
            // Điểm chạy chương trình

        // public static int tich(int a, int b)
        // {
        //     int result;
        //     result = a * b;
        //     return result;
        // }    
        
        // public static void Main(string[] args)
        // {   
            // cách gọi phương thức
            // có thể bỏ bớt khi cùng namespace, cùng lớp: xinchao();
            // int kq;
            // xinchao();
            // kq = tich(3,4);
           

            // Console.WriteLine(kq);

            // ---------VD------------

            // int x = 234;
            // int y = 456;
            // var result = Tinhtoan.tong(x, y);
            // Console.WriteLine(result);

            // float a = 12.12f;
            // float b = 10.0f;
            
            // var  result1 = Tinhtoan.tong(a, b);
            // Console.WriteLine(result1);

            // Truyền tham số với tên trong phương thức

            // xinchao("A", "Nguyen");
            // xinchao(ho: "Pham van", ten:"B");

            // Tham số giá trị mặc định
            // xinchao("x");
            // xinchao("X", "Pham");
        // }
        // --------Truyền tham số với tên trong phương thức--------------- 
        // static void xinchao(string ten, string ho)
        // {
        //     string fullname;
        //     fullname = ho + " " + ten;

        //     Console.WriteLine($"Xin chào {fullname}");
        // }


        // Tham số giá trị mặc định
        // static void xinchao(string ten, string ho = "Nguyen")
        // {
        //     string fullname;
        //     fullname = ho + " " + ten;

        //     Console.WriteLine($"Xin chào {fullname}");
        // }

        // public static void Main(string[] args)
        // {
        //     int a = 2;
        //     binhphuong(ref a);
        //     binhphuong(ref a);
        //     binhphuong(ref a);

        //     Console.WriteLine(a);
        // }

        // static void binhphuong(ref int x)
        // {
        //     x = x * x;
        //     Console.WriteLine(x);
        // }

        class Count {
            public int c = 1;
        }

        public static void Main(string[] args)
        {
            // int a;
            // binhphuong(4, out a);

            // Console.WriteLine(a);

            Count count = new Count();
            Console.WriteLine(count.c);

            dem(count);
            Console.WriteLine(count.c);
        }

        static void dem(Count count)
        {
            count.c ++;
        }

        // static void binhphuong(int x, out int kq) 
        // {
        //    kq = x * x;
        // }
    }
}