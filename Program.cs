using System;
using System.Linq;

namespace CS_hello_world
{
    class Program
    {
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        class Student {
            public string name;
            public Student(string name) {
                this.name = name;
                Console.WriteLine("Khoi tao " + name);
            }

            ~Student()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Huy " + name);
                Console.ResetColor();
            }

        }
        static void Main(string[] args)
        {   
        //    Vukhi sungluc; // null
        //    sungluc = new Vukhi();
        //    sungluc.name = "Sung luc";
        //    sungluc.Thietlapdosatthuong(5);
           
        //    sungluc.Noisanxuat = "My";
        //    Console.WriteLine(sungluc.Noisanxuat);

        //    Vukhi sungmay = new Vukhi("Sung may",15);

        //    sungluc.Tancong();
        //    sungmay.Tancong();

        // HÀM HỦY
        Student student;
        
        for (int i = 0; i < 1000; i++)
        {
            student = new Student("Sinh vien " + i);

            student = null;
        }

        GC.Collect();

        } 
    }
}