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
            for ( khởi_tạo; điều_kiện; cập_nhật )
            {
                //Các câu lệnh trong khối 
            }
            

            int i;
            for ( i = 1, Console.WriteLine("Khoi tao"); i <= 10; i++, Console.WriteLine("Cap nha i"))
            {
                Console.WriteLine($"i = {i}");
            }
            */

            // Ta có thể viết

            // int i = 1000;
            // for ( ; i <= 10; )
            // {
            //     Console.WriteLine($"3 * {i} = {3 * i}");
            //     i++;
            // }

            // for (int i = 1; i <= 10; i++)
            // Vòng lặp while
            // while ( i <= 10 )
            // {
            //     Console.WriteLine($"3 * {i} = {3 * i}");
            //     i++;
            // }

            // Vòng lập do while
            // do 
            // {
            //     Console.WriteLine($"3 * {i} = {3 * i}");
            //     i++;
            // }
            // while ( i <= 10 );

            // Từ khóa break và continue
            // -----------------BREAK---------------
            // int i = 0;
            // while ( i < 1000)
            // {
            //     Console.WriteLine(i);
            //     i++;

            //     if (i==11)
            //     // Khi gặp break thì dừng chương trình
            //         break; 

            // ---------CONTINUE-------------
            for (int i = 10; i <= 20; i++)
            {
                if ( i % 2 == 0) continue;

                Console.WriteLine($"so i = {i}");
            }

            // TÓM TẮT
            // Vòng lặp for thường thực hiện để lặp lại khối lệnh với số lần mà chúng ta biết rõ trước
            // Vòng lặp while xét điều kiện logic sau đó mới thực hiện khối lệnh và lặp lại khối lệnh đó khi mà điều kiện logic đó còn đúng
            // Vòng lặp do - while lúc nào nó cũng thực hiện khối lệnh đó trước ít nhất một lần sau đó mới kiểm tra điều kiện logic, nếu điều kiện logic đó là true nó sẽ lặp lại

            }
        }
    }
