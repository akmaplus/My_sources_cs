using System; 
using System.Configuration; 

class App
{ 
  static void Main(string[] args) 
  { 

    AppSettingsReader asr = new AppSettingsReader();   // Получаем специальные данные из файла *.config. 

    int repeatCount   =   (int)     asr.GetValue("RepeatCount", typeof(int)     ); 

    string textColor  =   (string)  asr.GetValue("TextColor",   typeof(string)  ); 

    Console.Write("RepeatCount:{0} TextColor:{1}", repeatCount, textColor);

  } 
} 
