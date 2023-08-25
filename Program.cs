using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_example
{
    class Program
    {
        //Anonymous - kiểu dữ liệu vô danh
        /* Objects (đối tượng) bên trong nó chứa những thuộc tính, trường dữ liệu - chỉ dùng dữ liệu để đọc
        - Để tạo ra một đối tượng kiểu vô danh ta sử dụng toán tử new:
        new {thuoctinh = giatri, thuoctinh2 = giatri2}
        -Đối tượng kiểu vô danh này bên trong nó có các thuộc tính, mỗi thuộc tính này đang chứa những giá trị và chúng ta
        chỉ có thể đọc những giá trị này ra mà không thể gán vào  */
    //     class Sinhvien {
    //         // Thuộc tính
    //         public string HoTen {set; get;}

    //         public int Namsinh {set; get;}

    //         public string Noisinh {set; get;}
    //     }
    //    static void Main(string[] args)
    //    {
    //     /* 
    //     - Thông thường những đối tượng kiểu vô danh sẽ lưu vào những biến ngầm định bằng từ khóa var
    //     - Không được gán giá trị vào kiểu vô danh
    //     */

    //     //Tạo đối tượng vô danh trong truy vấn Linq

    //     List<Sinhvien> cacsinhvien = new List<Sinhvien>() {
    //         new Sinhvien() {HoTen = "Nam", Namsinh = 2000, Noisinh = "Binh Duong"},
    //         new Sinhvien() {HoTen = "Dan", Namsinh = 2002, Noisinh = "Nam Dinh"},
    //         new Sinhvien() {HoTen = "Long", Namsinh = 2001, Noisinh = "Vinh Phuc"},
    //         new Sinhvien() {HoTen = "Minh", Namsinh = 2000, Noisinh = "Nam Dinh"},
    //     };

    //     // var ketqua = from sv in cacsinhvien
    //     //              where sv.Namsinh <= 2001
    //     //              select new { //Dữ liệu trả về
    //     //                 Ten = sv.HoTen,
    //     //                 NS = sv.Noisinh
    //     //              }; 

    //     var ketqua = from sv in cacsinhvien
    //                  where sv.HoTen.Contains("a")
    //                  select new { //Dữ liệu trả về
    //                     Ten = sv.HoTen,
    //                     NS = sv.Noisinh
    //                  }; 

    //     foreach (var Sinhvien in ketqua)
    //     {
    //         Console.WriteLine(Sinhvien.Ten + " - " + Sinhvien.NS);
    //     }

    //    }

    //-----------KIỂU DỮ LIỆU ĐỘNG DYNAMIC----------------
    // class Student {
    //     public string Name {set; get;} // Thuộc tính
    //     public void Hello() => Console.WriteLine(Name);
    // }
    // static void PrintInfo(dynamic obj) 
    // /* Do kiểu dynamic nên là biến này có thể có những thuộc tính, có những phương thức mà những thuộc tính phương thức ấy
    // phải xác định ở thời điểm thực thi nên ở thời điểm biên dịch tức là thời điểm viết code ta có thể truy cập
    // được những phương thức, những thuộc tính bất kì mà không gây ra lỗi nào đó */
    // {   
        
    //     obj.Name = "Khuong Nguyen"; //Thuộc tính
    //     obj.Hello(); // Phương thức 
    // }
    // static void Main(string[] args)
    // {
        // KHi khai báo biến không nhất thiết phải gán ngay giá trị cho nó
        /* Biến dynamic này có thể được gán bởi bất kì đối tượng nào và kiểu thực sự của dynamic
        được xác định ở thời điểm thực thi tức là thời điểm chạy chương trình */ 
        // dynamic tenbien1;
        /* Khi khai báo bằng từ khóa var đó là kiểu ngầm định thì chúng ta bắt buộc phải
        khởi tạo ngay giá trị cho nó và khi khởi tạo giá trị cho nó thì căn cứ vào giá trị được gán thì nó
        xác định cái kiểu của cái biến ngầm định này là kiểu gì */
        // var tenbien2 = 123;   


        // Student abc = new Student();
        // PrintInfo(abc);

        //-------------TỔNG KẾT LẠI------------
        static void Main(string[] args)
        {
            // Cách khai báo
            dynamic tenbien; 

            /* Biến kiểu dynamic này có thể được gán bằng một đối tượng bất kì từ số nguyên hay chuỗi hoặc bằng
            bất kì đối tượng nào đó */
            tenbien = 1;
            tenbien = "fgksl";
            tenbien = new {};

            /* Ở thời điểm viết code biến kiểu dynamic thì không xác định kiểu cụ thể do đó chúng ta có thể
            thoải mái truy cập những phương thức, những thuộc tính
            - Những phương thức, những thuộc tính này xác định có hay không thì nó sẽ xác định ở thời điểm thực thi
            hay biên dịch không có lỗi gì */
            tenbien.Acdef = "AAA";
            tenbien.Hello();

        }
    }

}

