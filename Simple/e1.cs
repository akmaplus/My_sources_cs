class App
{
 static void Main()
 {
     int a=0;

     label:                     //метка
     int i=0;
     a++;

     while(true)
     {
       Say("{0} {1}\n", a, i);

       if(i>3) break;           //выход за пределы блока

       Say("{0} {1}\n", a, i);

       i++;
     }

     if(a<2) goto label;        //переход к метке


     for(i=0, a=0; i<9; i++, a++)      //оператор запятая вполне работает!
     {
       Say("-");

       if(i>4) continue;        //пропуск всего что ниже, начать новую итерацию цикла, сначала блока

       Say("{0}\n", i);
     }

  }

  static void Say(string prm, params object[] prms){  //форматная печать
    System.Console.Write(prm, prms);          }
}
