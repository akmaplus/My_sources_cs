//использование несколько пространств имен, с одинаковыми именами внутри, и формы записи, для доступа к именам

using Emma = BovaryEnterprises.VeryUsefulLibrary;  //создаем псевдоним доступа к пространству имен
using Anna = KareninaSoftware.HandyDandyLibrary;

class ConsoleHelloWithUsing
{
  public static void Main()
  {
    //длинный вариант
    BovaryEnterprises.VeryUsefulLibrary.SuperString S1 = new BovaryEnterprises.VeryUsefulLibrary.SuperString();
    KareninaSoftware.HandyDandyLibrary.SuperString  S2 = new KareninaSoftware.HandyDandyLibrary.SuperString();

    //короткий вариант
    Emma.SuperString s1 = new Emma.SuperString();
    Anna.SuperString s2 = new Anna.SuperString();


    System.Console.WriteLine("{0}\n{1}\n", S1.NameLib, S2.NameLib);

    System.Console.WriteLine("{0}\n{1}\n", s1.NameLib, s2.NameLib);
  }
}
