using System;
using System.Linq;
using System.Text;

namespace CS_hello_world
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */

        // STRUCT (Kiểu tham trị) là kiểu dữ liệu có cấu trúc do chúng ta tự định nghĩa ra.
        public struct Product {
            // Dữ liệu...
            public string name;

            public double price;

            // Phương thức ...
            public string GetInfo()
            {
                return $"Ten san pham {name}, gia:{price}";
            }
            // Constructor (phương thức tạo - hàm tạo) || Đã sử dụng phương thức tạo thì tất cả các trường 
            //                                            dữ liệu này phải thiết lập giá trị trong phương thức tạo đó 
            public Product(string _name, double _price)
            {
                name =  _name;
                this.price = _price;
            }
        }

        static void Main(string[] args)
        {
           Product sanpham1;
           sanpham1.name = "Iphone";
           sanpham1.price = 1000;

        // Khi ta sử dụng phương thức khởi tạo thì ta phải sử dụng toán tử new
           Product sanpham2 = new Product("Nokia", 900);

           Console.WriteLine(sanpham1.GetInfo());
           Console.WriteLine(sanpham2.GetInfo());

        }
    }
}



