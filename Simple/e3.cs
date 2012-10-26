class App
{
  static void Main()
  {
    string[] lst = {"1","2","3","4","5","6","7"};
                                                                 //интерфейс IEnumerator
    System.Collections.IEnumerator en = lst.GetEnumerator();     //получаем перечислитель(итератор) объекта массив

    while( en.MoveNext() && en.Current!=null )  //используем перечислитель, для дампа массива
    { 
      Say("{0}\n", en.Current);  //печать текущего элемента перечислителя
    }

       //дамп массива используя интерфейс ILIst
    foreach(var item in lst)  Say("{0}\n", item);


    //класс ArrayList - расширяемый массив произвольных объектов
    System.Collections.ArrayList alst = new System.Collections.ArrayList();
    //добавляем разные элементы  в массив
    alst.Add(1);
    alst.Add("Hello");
    alst.Add(true);
    //перечисляем содержимое массива
    foreach(var item in alst)  Say("{0}\n", item);

  }
  static void Say(string prm, params object[] prms){  //форматная печать
    System.Console.Write(prm, prms);          }
}
