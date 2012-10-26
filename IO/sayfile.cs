                                        //странное - первый байт в файле ?????????????
class App
{
  static System.IO.FileStream fs;       //файловый поток - (запись/чтение) в файл двоичных данных
  static System.IO.BinaryWriter bw;     //двоичный врайтер - выдает поток байт на выход
  static System.Text.Encoding enc;

  static void Main()
  {
     enc = System.Text.Encoding.GetEncoding(1251);

     fs = new System.IO.FileStream("log.txt", System.IO.FileMode.Create , System.IO.FileAccess.Write ); //на запись
     bw = new System.IO.BinaryWriter(fs, enc);    //инициализация файловым потоком, с указанием рабочей кодировки
     
     //по умолчанию запись идет в кодировке utf8
     SayFile("{0} - {1} - {2}", "Hello", "File", "Приветик");
     fs.Close();
  }
   
   static void Say(string prm, params object[] prms){  //форматная печать на консоль
     System.Console.Write(prm, prms);               }

   static void SayFile(string prm, params object[] prms){  //форматная печать в файл
     bw.Write(System.String.Format(prm, prms));    }
}

/* Модификаторы файлового режима     
  System.IO.FileMode    .Truncate       усечь до нуля (пустого файла)
                        .OpenOrCreate   открыть или создать новый 
                        .Open           открыть существующий
                        .CreateNew      создать новый (если файл существует - генерируется исключение)
                        .Create         создать (если файл существует - он будет перезаписан, если файл уже существует (скрытый) - исключение) 
                        .Append         добавить к существ файлу
  доступа к файлу
  System.IO.FileAccess  .Write       Запись
                        .ReadWrite   запись-чтение
                        .Read        Чтение
*/
