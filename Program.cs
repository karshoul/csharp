// //--- Muốn nạp namespace ta dùng từ khóa using---------
// using System;
// using MyNameSpace; // có dùng này thì khi viết ra không cần dùng MyNameSpace trước tên lớp
// using xyz = MyNameSpace.Abc; // ta có thể đặt tên tắt cho namespace

// namespace CS_hello_world
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Class1.Xinchao();
//             xyz.Class1.Xinchao();
//         } 
//     }
// }

        //Nạp các phương thức tĩnh của lớp tĩnh với using
// using static System.Console;
// using static System.Math;
// namespace ns_example
// {
//     class Program 
//     {
//         static void Main(string[] args)
//         {
//            // WriteLine("Xin chao"); // tại đây ta có thể sử dụng tên của những phương thức tĩnh khai báo ở trong lớp đó mà ta không phải viết tên lớp ở đầu
//             WriteLine(PI);
//             WriteLine(Sin(PI/2));
//         }
//     }
// }

using static System.Console;
using static System.Math;
namespace ns_example
{
    class Program 
    {
        static void Main(string[] args)
        {
           Sanpham.Product product = new Sanpham.Product();
           product.name = "Ipad";
           product.price = 1000;
           product.description1 = "Day la Ipad";

           Sanpham.Product product1 = new Sanpham.Product(); 
           product1.manufactory.name = "samsung";
           product1.manufactory.addr = "Viet Nam";
           product1.manufactory.description2 = "Day la samsung";
           product1.manufactory = new Sanpham.Product.Manufactory();
           product1.manufactory.name = "Apple";

           WriteLine(product.GetInfo1());
           WriteLine(product.manufactory.GetInfo2());

        }
    }
}
