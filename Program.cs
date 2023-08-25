using System;
using System.Threading.Tasks.Dataflow;

namespace CS_hello_world
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        // THAM CHIẾU
        class Abc {
            public void Xinchao() => Console.WriteLine("Xin chao C#");
        }
        static void Main(string[] args)
        {
            // null. nullable
            /* null là từ khóa nó cho biết là nó không tham chiếu đến một đối tượng nào cả, được sử dụng cho biến kiểu tham 
            chiếu */

            // Abc a = new Abc();
            // // cách 1
            // if (a != null)
            //     a.Xinchao();
            // //Gọi phương thức khi đối tượng khác null
            // // Cách 2
            // a?.Xinchao();

            // ĐỐI VỚI BIẾN KIỂU THAM TRỊ 
            // Không được phép gán giá trị null
            // int i;
            // i = null;

            // -------------NULLABLE
            /* Để khai báo một biến kiểu tham trị có khả năng nhận giá trị null tha thêm dấu ? 
            VD:  int? age; */
            int? age;
            age = null;

            age = 110;
            // Để kiểm tra xem một biến nullable có có giá trị hay không thì ta sử dụng thuộc tính Hasvalue
            // if (age.HasValue) 
            // {
            //     int _age = age.Value;
            //     Console.WriteLine(_age);
            // }

            // Ta có thể kiểm tra giá trị khác null

            if (age != null) 
            {
                /*Khi ta biết chắn chán biến age khác null thì thay vì đọc giá trị của nó bằng thuộc tính Value như trên
                    thì ta có thể sử dụng kỹ thuật ép kiểu */

                //Ép kiểu như này nghĩa là ta truyền giá trị của biến age này sang kiểu int và gán cho biến tham trị int bth
                int _age = (int)age;
                Console.WriteLine(_age);
            }

        }
    }
}