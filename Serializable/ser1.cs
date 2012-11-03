using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class App
{
  static void Main()
  {
    App instance = new App();
    instance.Run();
  }
  public void Run()
  {
    Console.Write(this);
    SaveSoap();
    SaveBin();
  }

  public void SaveSoap()
  {
    using( MemoryStream ms = new MemoryStream() )
    {
        SoapFormatter frm = new SoapFormatter();
        frm.Serialize(ms, this);

        ms.WriteTo( new FileStream("ser.soap", FileMode.OpenOrCreate, FileAccess.Write) );
    }
  }

  public void SaveBin()
  {
    using( MemoryStream ms = new MemoryStream() )
    {
        BinaryFormatter frm = new BinaryFormatter();
        frm.Serialize(ms, this);

        ms.WriteTo( new FileStream("ser.bin", FileMode.OpenOrCreate, FileAccess.Write) );
    }
  }

  public override string ToString()
  {
   return "-App-";
  }
}