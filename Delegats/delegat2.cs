using System;      //Делегат - есть прототип(сигнатура или иначе тип) вызова функции, с расширенными возможностями
                   //в число которых входят операции над делегатами, не только, и поддержка всего этого на уровне компилятора и системы

delegate void MyDelegate(string s);  //создаем прототип функции(метода), обозначаем его ключевым словом delegate

class MyClass
{
    public static void Hello  (string s){ Say("  Hello, {0}!\n",   s);    }   //статические функции - печать вх. параметра
    public static void Goodbye(string s){ Say("  Goodbye, {0}!\n", s);    }   //с разницей во внутренней реализации, строчка другая;)


    public static void Main()
    {
        MyDelegate a, b, c, d;   //создаем переменные с типом, который определили выше - делегат
        
        a = new MyDelegate(Hello);      // Создание объекта делегата a, который ссылается на метод Hello:
        b = new MyDelegate(Goodbye);    // Создание объекта делегата b, который ссылается на метод Goodbye:

        // Два делегата a и b объединяются, чтобы создать делегат c, который вызывает оба метода в заявке:
        c = a + b;

        // Удаление a из составного делегата при сохранении d, который вызывает только метод Goodbye:
        d = c - a;

        Say("Invoking delegate a:");        a("A");
        Say("Invoking delegate b:");        b("B");
        Say("Invoking delegate c:");        c("C");
        Say("Invoking delegate d:");        d("D");
    }

  static void Say(string prm, params object[] prms){  //форматная печать
      System.Console.Write(prm, prms);             }
}

