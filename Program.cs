using System;

namespace CS_hello_world
{
    class Program
    {
        /*
        TÍNH KẾ THỪA
        A ,B
        B kế thừa A có nghĩa là một số phương thức, thuộc tính, trường dữ liệu của lớp A sẽ được B kế thừa lại
        - A gọi là "lớp cơ sở" hay "lớp cha"
        - B gọi là "lớp kế thừa" hay "lớp con"
        Khi có lớp cơ sở - lớp cha thì một lớp nào đó muốn kế thừa nó thì khi khai báo sẽ sử dụng:

        class B : A
        {

        }    
        VD: ta tạo ra một lớp cơ sở
        Animal
         - Legs
         - weight 
         - ShowLegs()

        Cat : Animal

        - Để một lớp không bao giờ được kế thừa bởi lớp khác để tránh phá vỡ logic lập trình nào đó thì khi khai báo lớp 
        ta cho thêm từ khóa "sealed" vào. (niêm phong)
        */
        // class Animal
        // {
        //     public int Legs{set; get;}
        //     public float weight{set; get;}
        //     public void Showlegs()
        //     {
        //         Console.WriteLine($"Legs: {Legs}");
        //     }
        // }

        // class Cat : Animal
        // {
        //     public string Food;
        //     public Cat()
        //     {
        //        this.Legs = 4;
        //        this.Food = "Mouse";
        //     }
        //     public void Eat()
        //     {
        //         Console.WriteLine(Food);
        //     }
        // }
        // static void Main(string[] args)
        // {
        //    Cat c = new Cat();
        //    c.Showlegs();
        //    c.Eat();

        // }

        //------Thay thê phương thức của lớp cơ sở(lớp cha)-----------
        //---- LỚP CƠ SỞ--------
        // class Animal
        // {
        //     public int Legs{set; get;}
        //     public float weight{set; get;}
        //     public void Showlegs()
        //     {
        //         Console.WriteLine($"Legs: {Legs}");
        //     }
        // }
        //-----LỚP KẾ THỪA--------
        // class Cat : Animal
        // {
        //     public string Food;
        //     public Cat()
        //     {
        //        this.Legs = 4;
        //        this.Food = "Mouse";
        //     }
        //     public void Eat()
        //     {
        //         Console.WriteLine(Food);
        //     }

        //     public new void Showlegs() //để biêt đây là phương thức khai báo lại mới ta cho vào từ khóa new
        //     {
        //         Console.WriteLine($"Loai meo co: {Legs} chan");
        //     }

        //     public void ShowInfo()
        //     {
        //         //Để truy cập đến thuộc tính hay phương thức được định nghĩa ở trong lớp cơ sở thì ở lớp kế thừa ta dùng từ khóa: "base"
        //         base.Showlegs();
        //         Showlegs();
        //     }
        // }
        // static void Main(string[] args)
        // {
        //    Cat c = new Cat();
        //    c.ShowInfo();

        // }

        //------Hoạt động của phương thức khởi tạo (constructor) ở lớp kế thừa và lơp cơ sở--------
        // class Animal
        // {
        //     public Animal()
        //     {
        //         Console.WriteLine("Khoi tao Animal");
        //     }

        //     public Animal(string abc)
        //     {
        //         Console.WriteLine($"Khoi tao Anime (2) - {abc}");
        //     }
        //     public int Legs{set; get;}
        //     public float weight{set; get;}
        //     public void Showlegs()
        //     {
        //         Console.WriteLine($"Legs: {Legs}");
        //     }
        // }
        // class Cat : Animal
        // {
        //     public string Food;

        //     /* Muốn phương thức khởi tạo của lớp kế thừa thi hành thì trước đó nó sẽ thi hành một phương thức khỏi tạo cụ thể
        //     nào đó của lớp cơ sở thì ta chỉ ra tại đây, để chỉ ra thì sau phương thức khởi tạo của lớp kế thừa ta gõ : basse()
        //     sau đó gọi phương thức khởi tạo vào của lớp cơ sở thì chúng ta xác định bằng các tham số tương ứng  */
        //     // Không có tham số thí nó gọi phương thức khởi tạo mặc định của lớp cơ sở
        //     // Nếu có tham số thì nó sẽ gọi phương thức khởi tạo khác
        //     /* Trong lớp kế thừa nếu ta định nghĩa phương thức khởi tạo của nó có tham số sẽ được truyền cho phương thức
        //     khởi tạo của lớp kể thừa sau đó lớp kế thừa truyền cho phương thức khởi tạo của lớp cơ sở */
        //     public Cat(string s) : base(s) 
        //     {
        //        this.Legs = 4;
        //        this.Food = "Mouse";
        //        Console.WriteLine("Khoi tao Cat");
        //     }
        //     public void Eat()
        //     {
        //         Console.WriteLine(Food);
        //     }

        //     public new void Showlegs() //để biêt đây là phương thức khai báo lại mới ta cho vào từ khóa new
        //     {
        //         Console.WriteLine($"Loai meo co: {Legs} chan");
        //     }

        //     public void ShowInfo()
        //     {
        //         //Để truy cập đến thuộc tính hay phương thức được định nghĩa ở trong lớp cơ sở thì ở lớp kế thừa ta dùng từ khóa: "base"
        //         base.Showlegs();
        //         Showlegs();
        //     }
        // }
        // static void Main(string[] args)
        // {
        //    Cat c = new Cat("Abc Zyc");

        // }

        //----Chuyển kiểu, ép kiểu giữa các đối tượng lớp thuộc cây kế thừa----------
        class A {}

        class B : A {};

        class C : B {};

        // A -> B -> C
        //Chú ý: một biến kiểu cơ sở có thể gán giá trị được khởi tạo ra từ những lớp kế thừa 
        //       một biến từ lớp kế thừa thì không thế gán bởi một đối tượng tạo ra từ lớp cơ sở

        class Program 
        {
            static void Main(string[] args)
            {
                A a;
                B b = new B();
                C c = new C();

                a = b;
                a = C;

                b = C;
            }
        }   
    }
}