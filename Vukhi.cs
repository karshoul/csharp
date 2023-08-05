using System;

namespace CS_hello_world
{
    /*
    <Access Modifiers> class Class_Name {
    // khai báo các thành viên dữ  liệu (thuộc tính, biến trường dữ liệu)
     // khai báo các thành viên  hàm (phương thức)
    }   
    */
    class Vukhi { 

        // DỮ LIỆU
        public string name = "Ten vu khi";
        int dosatthuong = 0;

        // THUỘC TÍNH

        public string Noisanxuat {set; get;}
        public int Satthuong{
            // Được thi hành khi thực hiện phép gán " = "
            set {
            // Các lệnh
            dosatthuong = value;
            }

            // Được thi hành khi truy cập, phải trả về giá trị cùng kiểu với THUỘC TÍNH
            get {
                return dosatthuong;
            }
        }


        // Phương thức khởi tạo
        public Vukhi()
        {   
            dosatthuong = 1;
        }

         public Vukhi(string name, int _dosatthuong)
        {   
            dosatthuong = _dosatthuong;
            this.name = name;
        }


        // Phương thức
        public void Thietlapdosatthuong(int dosatthuong)
        {
            this.dosatthuong = dosatthuong;

            // This - ref: tham chiếu trỏ đến đối tượng lớp hiện tại
            // Vukhi abc;
            // abc = this;
        }

        public void Tancong() 
        {
            Console.Write(name + ":\t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * "); 
            }
            Console.WriteLine();
        }
    }

}