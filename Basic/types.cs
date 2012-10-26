using System;      //использование пространства имен System необходимо для сокращен. использов. основных перечисленных ниже типов, кроме псевдонимов - не нужно

namespace b1
{
    class Program
    {
        static void Main(string[] args)
        {
          System.Object  sobj;
          Object          Obj;   //базовый объект
          object          obj;   //----псевдоним

          System.String   sS;
          String           S;     //строка 
          string           s;     //----псевдоним

          System.SByte   sSB;
          SByte           SB;     //-128 до 127
          sbyte           sb;     //----псевдоним

          System.Byte     sB;
          Byte             B;     //0 до 255
          byte             b;     //----псевдоним

          System.Int16    sW;
          Int16            W;     //int   -32768 до 32767
          short           sw;     //----псевдоним

          System.UInt16  sUw;
          UInt16          Uw;     //0 до 65535
          ushort         usw;     //----псевдоним

          System.Int32    sI;
          Int32            I;     //-2147483648 до 2147483647
          int              i;     //----псевдоним

          System.UInt32  sUi;
          UInt32          Ui;     //0 до 4294967295
          uint            ui;     //----псевдоним

          System.Int64    sL;
          Int64            L;     //-9223372036854775808 до 9223372036854775807
          long             l;     //----псевдоним

          System.UInt64  sUl;
          UInt64          Ul;     //0 до 18446744073709551615
          ulong           ul;      //----псевдоним

          System.Decimal  sD;
          Decimal          D;     //128 разр. число
          decimal          d;     //----псевдоним

          System.Char     sC;
          Char             C;     //16-разр. символ
          char             c;     //----псевдоним

          System.Single   sf;
          Single         Sgl;     //32-разр. числ. с плав. точкой IEEE
          float            f;     //----псевдоним

          System.Double   sd;
          Double         Dbl;     //64-разр. числ. с плав. точкой
          double         dbl;     //----псевдоним

          System.Boolean sBl;
          Boolean         Bl;     //булево
          bool            bl;     //----псевдоним

        }
    }
}

