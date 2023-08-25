using System;
namespace MyNameSpace {
    //class, struct, enum, interface,... ngoài ra nó còn cho phép khai báo namespace con ở trong nó
    public class Class1 {
        public static void Xinchao() {
           Console.WriteLine("Xin chao tu Class1");
        }
    }
    //namespace con lồng nhau
    namespace Abc {
        public class Class1 {
        public static void Xinchao() {
           Console.WriteLine("Xin chao tu Class1 cua namespace Abc");
        }
    }
    }

}