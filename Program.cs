using System;

namespace generic_example
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        /* Để chuyển tham số trong phương thức này thành dạng tham chiếu
        qua đó chúng ta thay đổi giá trị của tham số thì tương đương thay đổi giá trị 
        của biến chuyển vào, ta sử dụng từ khóa "ref" */
        // static void Swap(ref int x, ref int y) /* Trong phương thức này ta xây dựng giải thuật để x nhận giá trị của y
        //                                           y thì nhận giá trị của x */
        // {
        //     int t; // dùng biến tạm để lưu giá trị của x 
        //     t = x;
        //     x = y; // lúc này giá trị của x sẽ đc thay thế bằng y nên ta sẽ dùng biến tạm
        //     y = t;
        // }

        // static void Swap<T>(ref float x, ref float  y)
        // {
        //     float t; // dùng biến tạm để lưu giá trị của x 
        //     t = x;
        //     x = y; // lúc này giá trị của x sẽ đc thay thế bằng y nên ta sẽ dùng biến tạm
        //     y = t;
        // }
        // static void Main(string[] args)
        // {
        //     int a = 5;
        //     int b = 45;

        //     float c = 5;
        //     float d = 1;

        //     Console.WriteLine($"a = {a}, b = {b}");
        //     Swap(ref a, ref b); // Phương thức đổi số a thành b và ngược lại (Chỉ nhận 2 phương thức kiểu int), nếu tham số kiểu float nó sẽ gọi kiểu float
        //     Console.WriteLine($"a = {a}, b = {b}");

        //     Console.WriteLine($"c = {c}, d = {d}");
        //     Swap(ref c, ref d);
        //     Console.WriteLine($"c = {c}, d = {d}");


        // ---------------KHAI BÁO VÀ SỬ DỤNG GENERIC TRONG PHƯƠNG THỨC---------------
        // static void Swap<T>(ref T x, ref T y) 
        // /* Trong phương thức này ta xây dựng giải thuật để x nhận giá trị của y
        // y thì nhận giá trị của x
        // - T là kiểu dữ liệu 
        // - Khi áp dụng ta sẽ chỉ rõ T là biến kiểu gì, có thể là int, string, float,... */
        // {
        //     T t; // dùng biến tạm để lưu giá trị của x 
        //     t = x;
        //     x = y; // lúc này giá trị của x sẽ đc thay thế bằng y nên ta sẽ dùng biến tạm
        //     y = t;
        // }

        
        // static void Main(string[] args)
        // {
        //     double a = 45;
        //     double b = 1;

        //     Console.WriteLine($"a = {a}, b = {b}");
        //     //Swap(ref a, ref b); // Phương thức đổi số a thành b và ngược lại (Chỉ nhận 2 phương thức kiểu int), nếu tham số kiểu float nó sẽ gọi kiểu float
            
        //     /* Trong trường hợp ta muốn tường minh chỉ rõ kiểu đại diện của phương thức Swap khi áp dụng 
        //     nó là kiểu gì thì ta viết như sau 
        //     - Khi chúng ta chỉ rõ kiểu generic trước thì các tham số truyền vào sau đó phải đúng kiểu đó*/
        //     Swap<double>(ref a, ref b);
        //     Console.WriteLine($"a = {a}, b = {b}");

        //-----------------------SỬ DỤNG GENERIC TRONG LỚP-------------
        class Product<A> 
        {
            //dữ liệu
            A ID;

            //Phương thức
            public void SetID(A _id) // Dùng để thiết lập ID của sản phẩm
            {
                // Phương thức này để thiết lập ID của sản phẩm bằng ID chúng ta truyền vào
                this.ID = _id;
            }

            public void PrintInf()
            {
                Console.WriteLine($"ID = {this.ID}");
            }
        }
        static void Main(string[] args)
        {
            // Product<int> sanpham1 = new Product<int>();
            // sanpham1.SetID(123);
            // sanpham1.PrintInf();

            // Product<string> sanpham2 = new Product<string>();
            // sanpham2.SetID("Dienthoai");
            // sanpham2.PrintInf();

            List<int> list1 = new List<int>();
            List<string> list2 = new List<string>();

            //Cấu trúc dữ liệu Stack: vào sau ra trước
            Stack<int> stack; 

            //Giải thuật về hàng đợi vào trước được phục vụ trước
            Queue<double> q;

            
        }

    }
}
