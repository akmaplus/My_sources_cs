using System;

namespace ba
{
    //абстрактный класс
    public abstract class MyClass 
    { 
        //абстрактный метод (абстрактного класса)
        public abstract void DoSomething(); 
    } 

    //производный класс
    public class MyDerivedClass : MyClass 
    {
        //РЕАЛИЗАЦИЯ АБСТРАКТНОГО МЕТОДА (АК) - расскоментировать ниже для снятия ошибки
        //public override void DoSomething()
        //{
        //}
    } 

    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();              // Запрещено! НЕЛЬЗЯ СОЗДАТЬ ЭКЗЕМПЛЯР АБСТРАКТНОГО КЛАССА (АК)

            MyClass myClass = new MyDerivedClass () ;       // создаем экземпляр производного класса

            //myClass.DoSomething();                        //ОШИБКА - т.к. не был реализован абстрактный метод(АК)
        }
    }
}
