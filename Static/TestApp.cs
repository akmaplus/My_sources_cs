using System;      //���� ���祭�� ��⮤�� ����㯠 � ����᪨� 童��� ����� �� ���譨� ᡮઠ�


public class HelloMessage2 : HelloMessage       //��᫥ ������� : 㪠�뢠�� த�⥫�᪨� �����
{ 
  //��������� �� 㬮�砭�� - �ந�������� �����
  public HelloMessage2()
               : base()         //�맮� ��������� �������� ����� - ��᫥ ������� ᫮�� : base
  { 
    _msg = "hello";             //���塞 ���饭�� 童� �������� �����

    base.Test2 = "static";      //���塞 ᢮��⢮ �����, ������饥 ������� ��६�����

    //base.Test3 = "StAtIc";            //�� ����!!! ��⨪�!!! ;))))))))))))
    HelloMessage2.Test3 = "StAtIc";     //�� ��!! 㪠�뢠�� ��� �⮣� ����� � ����᪨� 童� �����, � ������ ��砥 㭠᫥������� �� ��������
  } 
}

 // ������ - ��� ����஫� ����᪨� 童��� �����(�⮡� �# �������� �� �㣠���), ����室��� ��᫥������� ����ᮢ � ࠡ�� � ���������� ���୥�� �����


class TestApp
{
  static void Main()
  {

   HelloMessage hm = new HelloMessage2();

   hm.Speak();
   hm.Speak2();

   hm.Test = "Hello Moto";      //����� � �㡫��� ᢮��⢠� �����
   hm.Test2 = "HELLO MOTO";

   hm.Speak();
   hm.Speak2();

   HelloMessage2.Say(); //���� ����� � ��⨪� �� ����� �����
   //hm.Say();         //�� �� �� ��뫪� �� �������!!!


   HelloMessage2.Test3 = "STATIC";   //ࠡ�⠥�! �� �� ��㯮 ;))))
   //hm.Test3 = "STATIC";   //⠪ �����!! ��⨪�, ⠪ �ᯮ�짮���� �㦭� � ���������, 㪠�뢠� ��� �����, �� ��뫪� �� �������!!!
   hm.Speak2();

  }
}

