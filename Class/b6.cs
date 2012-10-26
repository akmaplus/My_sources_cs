using System;

namespace b6
{
    class Program
    {
        //базовый класс - открытый
        public class Base 
        {
            //поле базового класса
            protected Int32 _x;       //защищенное поле - доступно из производного класса

            //ВИРТУАЛЬНОЕ свойство базового класса
            public virtual Int32 MyProperty 
            { 
                get { return _x; }      //возращаем значение внутренего поля
            } 

            //ВИРТУАЛЬНЫЙ метод базового класса
            public virtual void DoSomething() 
            { 
                _x = 13;                                    //присваиваем константу 13
                Console.WriteLine("Base.DoSomething");      //печать сигнатуры базового класса
            } 
        } 

        //производный класс - открытый
        public class Derived : Base 
        { 
            //ПЕРЕОПРЕДЕЛЕННОЕ свойство базового класса
            public override Int32 MyProperty 
            {
                get { return _x * 2; }  //возращаем удвоенное значение внутренего поля
            }

            //ПЕРЕОПРЕДЕЛЕННЫЙ метод базового класса
            public override void DoSomething() 
            {
                _x = 14;                                    //присваиваем константу 14
                base.DoSomething();                         //вызов метода базового класса
                Console.WriteLine("Derived.DoSomething");   //печать сигнатуры производного класса
            } 
        } 

        static void Main(string[] args)
        {
            Base d = new Derived();     //создаем экземпляр производного класса - в переменную БАЗОВОГО КЛАССА !!

            d.DoSomething();            //вызываем метод производного класса - (он переопределен)

            Console.WriteLine( d.MyProperty );  //доступ к свойству производного класса - (переопределено)
            Console.ReadKey();
        }
    }
}
