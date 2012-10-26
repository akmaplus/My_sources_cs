using System;

namespace b7
{   
    //базовый класс
    class Base 
    { 
        //ВИРТУАЛЬНЫЙ метод базового класса
        public virtual void DoSomethingVirtual() 
        { 
            Console.WriteLine("Base.DoSomethingVirtual"); 
        } 

        //метод базового класса - обычный
        public void DoSomethingNonVirtual() 
        { 
            Console.WriteLine("Base.DoSomethingNonVirtual"); 
        } 
    } 

    //производный класс
    class Derived : Base 
    { 
        //ПЕРЕОПРЕДЕЛЕННЫЙ метод производного класса
        public override void DoSomethingVirtual() 
        { 
            Console.WriteLine("Derived.DoSomethingVirtual"); 
        }

        //ЗАМЕЩЕННЫЙ (new) метод производного класса  - вызывается только через сигнатуру этого (переопределеннного) класса
        public new void DoSomethingNonVirtual() 
        { 
            Console.WriteLine("Derived.DoSomethingNonVirtual"); 
        } 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derived via Base reference:\n");
            Base baseRef = new Derived();                           //создаем ПРОИЗВОДНЫЙ класс в сигнатуру БАЗОВОГО класса

            baseRef.DoSomethingVirtual();                           //вызываем виртуальный метод
            baseRef.DoSomethingNonVirtual();                        //вызываем обычный метод
            
            Console.WriteLine("\n\nDerived via Derived reference:\n");
            Derived derivedRef = new Derived();                     //создаем ПРОИЗВОДНЫЙ класс в сигнатуру ПРОИЗВОДНОГО класса

            derivedRef.DoSomethingVirtual();                        //вызываем виртуальный метод
            derivedRef.DoSomethingNonVirtual();                     //вызываем обычный метод
            Console.ReadKey();

        }
    }
}
