using System;

namespace UpCast
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A b = new B(); //Приводим тип B к родительскому типу А (апкаст)
            a.ShowMessage(); //message
            b.ShowMessage(); //override message
            Parent parent = new C();
            parent.Test2();
            Console.ReadKey();
        }
    }
    class A //Родитель
    {
        public virtual void ShowMessage() //Виртуальный метод
        {
            Console.WriteLine("message");
        }
    }
    class B : A // Наследник
    {
        public override void ShowMessage() // Переопределяем виртуальеный метод
        {
            Console.WriteLine("override message");
        }
    }

    class Parent //родитель
    {
        public virtual void Test2()
        {
            Console.WriteLine("parent test2 method");
        }
    }
    class C : Parent //наследуем
    {
        public void Test ()
        {
            Console.WriteLine("test method");
        }
        public override void Test2() //переопределяем
        {
            this.Test();
        }
    }
}
