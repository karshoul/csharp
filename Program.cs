// using System;
// using System.Linq;

// namespace CS_hello_world
// {
//     class Program
//     {
//         /*
//             Đây là hàm Main
//             Điểm chạy chương trình
//         */
//         class Student {
//             public string name;
//             public Student(string name) {
//                 this.name = name;
//                 Console.WriteLine("Khoi tao " + name);
//             }

//             ~Student()
//             {
//                 Console.ForegroundColor = ConsoleColor.Red;
//                 Console.WriteLine("Huy " + name);
//                 Console.ResetColor();
//             }

//         }
//         static void Main(string[] args)
//         {   
//         //    Vukhi sungluc; // null
//         //    sungluc = new Vukhi();
//         //    sungluc.name = "Sung luc";
//         //    sungluc.Thietlapdosatthuong(5);
           
//         //    sungluc.Noisanxuat = "My";
//         //    Console.WriteLine(sungluc.Noisanxuat);

//         //    Vukhi sungmay = new Vukhi("Sung may",15);

//         //    sungluc.Tancong();
//         //    sungmay.Tancong();

//         // HÀM HỦY
//         Student student;
        
//         for (int i = 0; i < 1000; i++)
//         {
//             student = new Student("Sinh vien " + i);

//             student = null;
//         }

//         GC.Collect();

//         } 
//     }
// }

using System;
using System.Linq;

namespace CS_hello_world
{
    /*
        Đây là hàm Main
        Điểm chạy chương trình
    */
    class Student : IDisposable
    {
        public string name;
        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Khoi tao " + name);
        }

        ~Student()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy " + name);
            Console.ResetColor();
        }

        public void Dispose()
        {
            // Giải phóng tài nguyên mà nó chiếm giữ
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Huy (boi dispose) " + name);
            Console.ResetColor();
        }
    }

    class Program
    {
        static void test()
        {
            using Student sv = new Student("Ten");
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3"); 
        }
        static void Main(string[] args)
        {
            // using (Student s = new Student("Ten sinh  vien"))
            {
                test();
                // biến s chỉ có hiệu lực trong này
            }
        }
    }
}



