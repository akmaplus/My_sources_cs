using System;

namespace b5
{
    class Program
    {
        //базовый класс - открытый
        public class BaseClass 
        { 
            //поля класса
            private     int _a;     //закрытое поле
            protected   int _b;     //защищенное поле (разрешено в классе и производном классах)
            public      int _c;     //публичное поле

            //конструктор базового класса
            public BaseClass(int x, int y, int z)
            {
            }

        } 

        //дочерний (производный) класс - открытый
        public class DerivedClass : BaseClass       //после двоеточия : указываем родительский класс
        { 
            //конструктор по умолчанию - производного класса
            public DerivedClass()
                : base(1, 2, 3)         //вызов конструктора базового класса - после двоеточия слово : base
            { 
                //_a = 1;       // Так нельзя! Переменная имеет модификатор private в BaseClass 
                _b = 2;         // ok 
                _c = 3;         // ок 
} 
            //метод производного класса
            public void DoSomething() 
            { 
                _c = _b = 99;   //доступ к полям родительского класса
            } 
        } 

        static void Main(string[] args)
        {
        }
    }
}
