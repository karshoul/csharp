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
            // Đây là nội dung in ra màn hình
            Console.WriteLine("Xin chao C#!");
            Console.Read();
        }

        /// <summary>
        /// Phương thức trả về tổng của hai số nguyên
        /// </summary>
        /// <param name="a"> số nguyên 1 </param>
        /// <param name="b"> số nguyên 2 </param>
        /// <returns> Tổng a + b </returns>
        static int Tong(int a, int b) 
        {
            return ( a + b );
        }
    }
}