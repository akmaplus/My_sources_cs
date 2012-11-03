using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class App : ISerializable
{
  public int[] lst;

  public App() {}   //пустой конструктор - обязателен

  static void Main()
  {
    App instance = new App();
    instance.Run();
  }
  public void Run()
  {
    lst = new int[3];
    lst[0] = 1;
    SaveSoap();
    lst[0] = 3;
    RestFromSoap();
    Console.WriteLine("{0}", lst[0]);
  }

  public void SaveSoap()
  {
    using( MemoryStream ms = new MemoryStream() )
    {
        SoapFormatter frm = new SoapFormatter();
        frm.Serialize(ms, this);

        using(FileStream fs = new FileStream("ser.soap", FileMode.OpenOrCreate, FileAccess.Write))
        ms.WriteTo( fs );
    }
  }

  public void RestFromSoap()
  {
    FileStream fs = new FileStream("ser.soap", FileMode.Open);
    SoapFormatter frm = new SoapFormatter();
    App instance = (App)frm.Deserialize(fs);
    this.lst = instance.lst;
  }

  public void GetObjectData(SerializationInfo info, StreamingContext context)
  {
   info.AddValue("lst", lst, typeof(int[])); 
  }

  public App(SerializationInfo info, StreamingContext context)
  {
    lst = (int[]) info.GetValue("lst", typeof(int[]));
  }
}