using System;
using System.Linq;

namespace CS_hello_world
{
        /*
            Đây là hàm Main
            Điểm chạy chương trình
        */
        class Student : IDisposable {
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
        public void Dispose()
        {
            // Giải phóng tài nguyên mà nó chiếm giữ
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Huy (boi dispose) " + name);
                Console.ResetColor();
        }

        class Main1 
        {
        static void Main(string[] args)
        {
            using (Student s = new Student("Ten sinh  vien"))
            {
                // biến s chỉ có hiệu lực trong này
            }

            }
        }
}

        
    
