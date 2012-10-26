using System;      //������� - ���� ��������(��������� ��� ����� ���) ������ �������, � ������������ �������������
                   //� ����� ������� ������ �������� ��� ����������, �� ������, � ��������� ����� ����� �� ������ ����������� � �������

delegate void MyDelegate(string s);  //������� �������� �������(������), ���������� ��� �������� ������ delegate

class MyClass
{
    public static void Hello  (string s){ Say("  Hello, {0}!\n",   s);    }   //����������� ������� - ������ ��. ���������
    public static void Goodbye(string s){ Say("  Goodbye, {0}!\n", s);    }   //� �������� �� ���������� ����������, ������� ������;)


    public static void Main()
    {
        MyDelegate a, b, c, d;   //������� ���������� � �����, ������� ���������� ���� - �������
        
        a = new MyDelegate(Hello);      // �������� ������� �������� a, ������� ��������� �� ����� Hello:
        b = new MyDelegate(Goodbye);    // �������� ������� �������� b, ������� ��������� �� ����� Goodbye:

        // ��� �������� a � b ������������, ����� ������� ������� c, ������� �������� ��� ������ � ������:
        c = a + b;

        // �������� a �� ���������� �������� ��� ���������� d, ������� �������� ������ ����� Goodbye:
        d = c - a;

        Say("Invoking delegate a:");        a("A");
        Say("Invoking delegate b:");        b("B");
        Say("Invoking delegate c:");        c("C");
        Say("Invoking delegate d:");        d("D");
    }

  static void Say(string prm, params object[] prms){  //��������� ������
      System.Console.Write(prm, prms);             }
}

