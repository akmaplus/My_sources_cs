//���⨯ ��⮤� - �������
delegate void TestDelegat(int prm);

class Test{
 public int Num =0;
 public void say(int p){ System.Console.Write("{0}:{1}\n", Num, p); }
}

class App
{
  static void Main()
  {
    //���樠������ ������⮢, 㪠����� ��⮤��
    TestDelegat a = new TestDelegat(Test1);
    TestDelegat b = new TestDelegat(Test2);
    TestDelegat c = new TestDelegat(Test3);

    //�맮� ��⮤��, �१ �������
    a(1);
    b(2);
    c(3);

    //���樠������ ������� �� ��� ������⮢, �������஢����
    TestDelegat d = a + b + c;  

    //�맮� ������� - ��� ��⮤�� ��।������� ��� 
    d(7);

    d -= a;  //������ ��� ������⮬, ���� ��⮤, ᮡ�⢥��� �������

    d(9);    //�맮� �������, ���� ��⠢���� ��⮤��

    //��������� �������� � ������������� ��������
    Test cl = new Test();  //���� ��⮢� �����

    cl.say(6);  //��� ��⮤� �����

    //���樠������ �������, 㪠����� ��⮤��, ������� �����
    TestDelegat e = new TestDelegat( cl.say );

    cl.Num = 7; //���塞 ���� � ������� �����  - � ���� �����, ������� ࠡ�⠥� ������ � �⨬ ������஬!
    e(3);   //��뢠�� �������, ��� ��直� �祪, ��� ��⮤
  }

  static void Test1(int prm){ Say("{0}\n",   prm); }  //����������� ������, ������
  static void Test2(int prm){ Say("{0},\n",  prm); }
  static void Test3(int prm){ Say("{0}.\n",  prm); }

  static void Say(string prm, params object[] prms){  //�ଠ⭠� �����
      System.Console.Write(prm, prms);             }
}
