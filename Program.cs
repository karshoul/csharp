using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

namespace CS_hello_world
{
    
    // Virtual - Phương thức ảo
    /* Phương thức ảo là phương thức được định nghĩa ở trong lớp cơ sở, phương thức đó có thể được ghi đè
    bởi lớp kế thừa  
    - Để cho biết một phương thức là phương thức ảo thì khi định nghĩa phương thức thì sau khi xác định phạm vi truy cập
    ta cho thêm vào từ khóa "virtual" 
    */ 
    // class Product 
    // {
    //     protected double Price {set; get;}
    //     public virtual void ProductInfo() // Phương thức này có thể bị định nghĩa lại, bị ghi đè bởi lớp kế thừa
    //     {
    //         Console.WriteLine($"Gia san pham: {Price}");
    //     }

    //     public void Test() => ProductInfo(); 
    // }

    // /* Tại lớp kế thừa Iphone muốn định nghĩa lại một phương thức đã có ở trong lớp cơ sở, trong những trường hợp như vậy 
    // thì tại lớp cơ sở phải cho biết là những phương thức nào có thể bị ghi đè, bị định nghĩa lại bởi lớp kế thừa, những
    // phương thức cho biết là nó có thể bị định nghĩa lại, bị ghi đè lại gọi là những phương thức ảo. */
    // class Iphone : Product 
    // {
    //     // Phương thức
    //     public Iphone() => Price = 500; // Khai báo phương thức ngắn gọn  với "=>"

    //     // Nạp chồng (override) phương thức 
    //     // từ khóa "override cho biết phương thức này sẽ ghi đè vào phương thức đã được định nghĩa ở lớp cơ sở
    //     public override void ProductInfo()
    //     {
    //         Console.WriteLine("Dien thoai Iphone");

    //         // Khi ta muốn gọi phương thức ProductInfo đã được định nghĩa ở lớp cơ sở thì ta cho vào từ khóa: "base"
    //         base.ProductInfo();
    //     }
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Iphone i = new Iphone();

    //         /* Khi chạy nó sẽ gọi ProductInfo trong lớp cơ sở nhưng do ở lớp kế thừa đã định nghĩa lại nó nên nó sẽ 
    //         gọi ProductInfo trong lớp kế thừa */
    //         i.Test();


    //     }
    // }

    //------------- KHAI BÁO VÀ SỬ DỤNG LỚP TRỪU TƯỢNG ABSTRACT----------------
    /* Trong lập trình hướng đối tượng nhiều khi ta muốn tạo ra những lớp mà nó không được dùng để tạo ra những đối tượng
    mà nó chỉ được dùng để làm cơ sở cho những lớp kế thừa 
    - Khi đó khai báo lớp ta dùng từ khóa "abstract"
    - Đã là lớp trừu tượng thì nó không được dùng để tạo ra các đối tượng chỉ được dùng làm cơ sở cho những lớp kế thừa
    - Trong khai báo các phương thức của lớp trừu tượng chúng ta có thể khai báo một phương thức đó là phương thức trừu tượng
    - Để khai báo một phương thức là phương thức trừu tượng ta khai báo phương thức sau phạm vi truy cập
    - Đã là phương thức trừu tượng thì lớp kế thừa phải định nghĩa lại nó tức là phải nạp chồng lại nó  */
    // abstract class Product 
    // {
    //     protected double Price {set; get;}
    //     public abstract void ProductInfo();

    //     public void Test() => ProductInfo(); 
    // }

    // /* Tại lớp kế thừa Iphone muốn định nghĩa lại một phương thức đã có ở trong lớp cơ sở, trong những trường hợp như vậy 
    // thì tại lớp cơ sở phải cho biết là những phương thức nào có thể bị ghi đè, bị định nghĩa lại bởi lớp kế thừa, những
    // phương thức cho biết là nó có thể bị định nghĩa lại, bị ghi đè lại gọi là những phương thức ảo. */
    // class Iphone : Product 
    // {
    //     // Phương thức
    //     public Iphone() => Price = 500; // Khai báo phương thức ngắn gọn  với "=>"
    //     public override void ProductInfo()
    //     {
    //         Console.WriteLine("Dien thoai Iphone");
    //         Console.WriteLine($"Gia san pham {Price}");
    //     }

        
    // }
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Iphone i = new Iphone();
    //         i.Test();



    //     }
    // }

    //------------GIAO DIỆN INTERFACE---------------
    /* Interface khá giống với lớp abstract(lớp trừu tượng) tức là khai báo ra cấu trúc một lớp nhưng không được dùng
    để tạo ra đối tượng mà nó chỉ được dùng để làm cơ sở cho các lớp kế thừa 
    - Nó khác abstract ở chỗ là các phương thức trong interface thì mặc định chỉ cần khai báo tên và nó là phương thức trừu 
    tượng nghĩa là lớp cơ sở bắt buộc phải định nghĩa lại phương thức đó hay nói cách khác là triển khai phương thức đó
     */  
     interface IHinhHoc // tên giao diện thường bắt đầu bằng chữ I
     {
        /* trong này ta định nghĩa ra những phương thức, những phương thức này chỉ khai báo tên thôi 
        và không cần thân phương thức */

        // Phương thức
        public double TinhChuVi();
        public double TinhDienTich();

     }

     // TRIỂN KHAI GIAO DIỆN
     class HinhChuNhat : IHinhHoc
     {
        public HinhChuNhat(double _a, double _b)
        {
            a = _a;
            b = _b;
        }
        public double a {set; get;}
        public double b {set; get;}

        public double TinhChuVi()
        {
            return 2 * (a + b );
        }

        public double TinhDienTich()
        {
            return a * b;
        }
    }

    class HinhTron : IHinhHoc 
    {
        public double r {set; get;}
        public HinhTron (double _r) => r = _r;

        public double TinhChuVi()
        {
            return 2 * r * Math.PI;
        }

        public double TinhDienTich()
        {
            return Math.PI * r * r;
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            HinhChuNhat h = new HinhChuNhat(4, 5);
            Console.WriteLine($"Dien tich: {h.TinhDienTich()}, Chu vi: {h.TinhChuVi()}");
            
            HinhTron t = new HinhTron(2); 
            Console.WriteLine($"Dien tich: {t.TinhDienTich()}, Chu vi: {t.TinhChuVi()}");
        }
    }
}