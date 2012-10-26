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
        //–≈јЋ»«ј÷»я јЅ—“–ј “Ќќ√ќ ћ≈“ќƒј (ј ) - расскоментировать ниже дл€ сн€ти€ ошибки
        //public override void DoSomething()
        //{
        //}
    } 

    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();              // «апрещено! Ќ≈Ћ№«я —ќ«ƒј“№ Ё «≈ћѕЋя– јЅ—“–ј “Ќќ√ќ  Ћј——ј (ј )

            MyClass myClass = new MyDerivedClass () ;       // создаем экземпл€р производного класса

            //myClass.DoSomething();                        //ќЎ»Ѕ ј - т.к. не был реализован абстрактный метод(ј )
        }
    }
}
