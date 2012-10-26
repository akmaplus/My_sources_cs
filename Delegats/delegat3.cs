//прототип метода - делегат
delegate void TestDelegat(int prm);

class Test{
 public int Num =0;
 public void say(int p){ System.Console.Write("{0}:{1}\n", Num, p); }
}

class App
{
  static void Main()
  {
    //инициализация делегатов, указанным методом
    TestDelegat a = new TestDelegat(Test1);
    TestDelegat b = new TestDelegat(Test2);
    TestDelegat c = new TestDelegat(Test3);

    //вызов методов, через делегат
    a(1);
    b(2);
    c(3);

    //инициализация делегата из трех делегатов, комбинирование
    TestDelegat d = a + b + c;  

    //вызов делегата - трех методов определенных выше 
    d(7);

    d -= a;  //операция над делегатом, убрать метод, собственно делегат

    d(9);    //вызов делегата, двух оставшихся методов

    //ТЕСТИРУЕМ ДЕЛЕГАТЫ С ЭКЗЕМПЛЯРНЫМИ МЕТОДАМИ
    Test cl = new Test();  //новый тестовый класс

    cl.say(6);  //тест метода класса

    //инициализация делегата, указанным методом, экземпляра класса
    TestDelegat e = new TestDelegat( cl.say );

    cl.Num = 7; //меняем поле в экземпляре класса  - и ниже видим, делегат работает именно с этим экземпляром!
    e(3);   //вызываем делегат, без всяких точек, как метод
  }

  static void Test1(int prm){ Say("{0}\n",   prm); }  //ПРОСТЕНЬКИЕ МЕТОДЫ, ПЕЧАТЬ
  static void Test2(int prm){ Say("{0},\n",  prm); }
  static void Test3(int prm){ Say("{0}.\n",  prm); }

  static void Say(string prm, params object[] prms){  //форматная печать
      System.Console.Write(prm, prms);             }
}
