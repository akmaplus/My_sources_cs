class App
{
 static void Main()
 {
     string fn = "test";

     using ( System.IO.FileStream   fs = new System.IO.FileStream(fn, System.IO.FileMode.Open, System.IO.FileAccess.Read) )
     // using ( System.IO.BinaryReader br = new System.IO.BinaryReader(fs))
     { 
           Say("Filesize:{0} bytes\nPos:{1}\n", fs.Length, fs.Position);

            byte [] bt = new byte[100];

            //while(true)
            if( bt[0] != fs.ReadByte() )
              break; //Say("EOF");
            else 
              Say("{0}\n", bt[0]); 

            //if ( bt[0] != fs.ReadByte() )
            //if (b != fs.ReadByte())

            //Say("{0}\n", bt);


      //SayFile(bw, "{0} - {1}\n", "Привет", "файл");

     }

 }
   static void Say(string prm, params object[] prms){  //форматная печать
     System.Console.Write(prm, prms);               }
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
