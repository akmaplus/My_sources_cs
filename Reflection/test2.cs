using System;
using System.Reflection;

class App
{
 static void Main()
 {
    Type t = Type.GetType("System.Console");   //получаем тип по строке, содержащей имя типа, с префиксом пространства имен

    Say("{0}\n", t.GUID);   //печатаем идентификатор перечисления (нашего исх. типа)
    Say("{0}\n", t.FullName);  //полное имя типа

    print(t.GetProperties(),     "Properties");
    print(t.GetMethods(),        "Methods");
    print(t.GetEvents(),         "Events");
    print(t.GetMembers(),        "Members");

    print(t.GetFields(),         "Fields");
    print(t.GetNestedTypes(),    "NestedTypes");
    print(t.GetInterfaces(),     "Interfaces");
    print(t.GetConstructors(),   "Constructors");
    print(t.GetDefaultMembers(), "DefaultMembers");

 }
 static void Say(string prm, params object[] prms){
     System.Console.Write(prm, prms);             }

 static void print(object[] sa, string capt)
 {
    int cnt=0;
    Say("\n{0}\n", capt);
    foreach(var x in sa)
    {
        string s = x.ToString();
        string[] ss = s.Split(new Char[] {' '});
        Say("{0,30} {1}", ss[0], ss[1]);
        for(int i=2; i<ss.Length; i++)
            Say(" {0}", ss[i]);
        Say("\n");
        cnt++;
    }
    Say("={0}\n", cnt);
 }
}
