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
        // Các kiểu dữ liệu lớp là kiểu tham chiếu. 
        // STRUCT (Kiểu tham trị) VD: số nguyên int, kiểu logic, bool... là kiểu dữ liệu có cấu trúc do chúng ta tự định nghĩa ra.
        // public struct Product {
        //     // Dữ liệu...
        //     public string name;

        //     public double price;

        //     public string Info{
        //         get{
        //             return $"{name}, {price}";
        //         }   
        //     }

        //     // Phương thức ...
        //     public string GetInfo()
        //     {
        //         return $"Ten san pham {name}, gia:{price}";
        //     }
        //     // Constructor (phương thức tạo - hàm tạo) || Đã sử dụng phương thức tạo thì tất cả các trường 
        //     //                                         || dữ liệu này phải thiết lập giá trị trong phương thức tạo đó 
        //     public Product(string _name, double _price)
        //     {
        //         name =  _name;
        //         this.price = _price;
        //     }
        // }

        // static void Main(string[] args)
        // {
        //    Product sanpham1;
        //    sanpham1.name = "Iphone";
        //    sanpham1.price = 1000;

        // // Khi ta sử dụng phương thức khởi tạo thì ta phải sử dụng toán tử new
        //    Product sanpham2 = new Product("Nokia", 900);

        //    Console.WriteLine(sanpham1.GetInfo());
        //    Console.WriteLine(sanpham2.GetInfo());
        //    Console.WriteLine(sanpham2.Info);

        // ----------------CLASS--------------
        // public class Product {
        //     // Dữ liệu...
        //     public string name;

        //     public double price;

        //     public string Info{
        //         get{
        //             return $"{name}, {price}";
        //         }   
        //     }

        //     // Phương thức ...
        //     public string GetInfo()
        //     {
        //         return $"Ten san pham {name}, gia:{price}";
        //     }
        //     // Constructor (phương thức tạo - hàm tạo) || Đã sử dụng phương thức tạo thì tất cả các trường 
        //     //                                         || dữ liệu này phải thiết lập giá trị trong phương thức tạo đó 
        //     public Product(string _name, double _price)
        //     {
        //         name =  _name;
        //         this.price = _price;
        //     }
        // }

        // // Đối với lớp sau khi khai bao biến thì bắt buộc phải khởi tạo ra đối tượng
        // static void Main(string[] args)
        // {
        //    Product sanpham1 = new Product("",0);
        //    sanpham1.name = "Iphone";
        //    sanpham1.price = 1000;

        // // Khi ta sử dụng phương thức khởi tạo thì ta phải sử dụng toán tử new
        //    Product sanpham2 = new Product("Nokia", 900);

        //    sanpham2 = sanpham1;
        //    sanpham2.name = "Iphone X";

        //    Console.WriteLine(sanpham1.GetInfo());
        //    Console.WriteLine(sanpham2.GetInfo());
        //    Console.WriteLine(sanpham2.Info);

        //-----------KIỂU LIỆT KÊ: ENUM---------------
        /*  
        Để phân loại học lực của học sinh:
            0 - kém
            1 - trung bình
            2 - khá
            3 - giỏi
         
        */
        // CÓ thể cho giá trị trực tiếp nhưng ý nghĩa không thay đổi
        // enum HOCLUC {
        //     Kem = 221,        
        //     Trungbinh = 12,  
    
        //     Kha, 
            
        //     Gioi}
        // static void Main(string[] args)
        // {   
        //     // int hocluc;
        //     // hocluc = 3;
        //     // // if (hocluc == 2)
        //     // // {
        //     // //     Console.WriteLine("Học lực khá");
        //     // // }

        //     // // Ta có thể sử dụng cấu trúc switch - case
        //     // switch (hocluc)
        //     // {
        //     //     case 0:
        //     //         Console.WriteLine("Hoc luc kem");
        //     //     break;

        //     //     case 1:
        //     //         Console.WriteLine("Hoc luc trung binh");
        //     //     break;

        //     //     case 2:
        //     //         Console.WriteLine("Hoc luc kha");
        //     //     break;

        //     //     case 3:
        //     //         Console.WriteLine("Hoc luc gioi");
        //     //     break;

        //     //---- ENUM ----------
        //     HOCLUC hocluc;
        //     hocluc = HOCLUC.Kha;
        //     switch (hocluc)
        //     {
        //         case HOCLUC.Kem:
        //             Console.WriteLine("Hoc luc kem");
        //         break;

        //         case HOCLUC.Trungbinh:
        //             Console.WriteLine("Hoc luc trung binh");
        //         break;

        //         case HOCLUC.Kha:
        //             Console.WriteLine("Hoc luc kha");
        //         break;

        //         case HOCLUC.Gioi:
        //             Console.WriteLine("Hoc luc gioi");
        //         break;
        //     }
        // }

        //-------ÉP KIỂU ENUM SANG SỐ VÀ NGƯỢC LẠI-----------
        enum HOCLUC {
            Kem = 221,        

            Trungbinh = 12,  
    
            Kha, 
            
            Gioi}
        static void Main(string[] args)
        { 

            //---- ENUM ----------
            HOCLUC hocluc;
            hocluc = HOCLUC.Kem;
            
            //Chuyển đổi enum sang số
            // int so = (int)hocluc;
            // Console.WriteLine(so);

            //Chuyển kiểu số sang enum
            hocluc = (HOCLUC)(221);

            switch (hocluc)
            {
                case HOCLUC.Kem:
                    Console.WriteLine("Hoc luc kem");
                break;

                case HOCLUC.Trungbinh:
                    Console.WriteLine("Hoc luc trung binh");
                break;

                case HOCLUC.Kha:
                    Console.WriteLine("Hoc luc kha");
                break;

                case HOCLUC.Gioi:
                    Console.WriteLine("Hoc luc gioi");
                break;
            }
        }

    }
}




