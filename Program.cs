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


        */
        class Animal
        {
            public int Legs{set; get;}
            public float weight{set; get;}
            public void Showlegs()
            {
                Console.WriteLine($"Legs: {Legs}");
            }
        }

        class Cat : Animal
        {
            public string Food;
            public Cat()
            {
               this.Legs = 4;
               this.Food = "Mouse";
            }
            public void Eat()
            {
                Console.WriteLine(Food);
            }
        }
        static void Main(string[] args)
        {
           Cat c = new Cat();
           c.Showlegs

        }
    }
}