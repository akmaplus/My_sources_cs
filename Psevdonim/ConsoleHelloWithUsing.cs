//�ᯮ�짮����� ��᪮�쪮 ����࠭�� ����, � ��������묨 ������� �����, � ��� �����, ��� ����㯠 � ������

using Emma = BovaryEnterprises.VeryUsefulLibrary;  //ᮧ���� �ᥢ����� ����㯠 � ����࠭��� ����
using Anna = KareninaSoftware.HandyDandyLibrary;

class ConsoleHelloWithUsing
{
  public static void Main()
  {
    //������ ��ਠ��
    BovaryEnterprises.VeryUsefulLibrary.SuperString S1 = new BovaryEnterprises.VeryUsefulLibrary.SuperString();
    KareninaSoftware.HandyDandyLibrary.SuperString  S2 = new KareninaSoftware.HandyDandyLibrary.SuperString();

    //���⪨� ��ਠ��
    Emma.SuperString s1 = new Emma.SuperString();
    Anna.SuperString s2 = new Anna.SuperString();


    System.Console.WriteLine("{0}\n{1}\n", S1.NameLib, S2.NameLib);

    System.Console.WriteLine("{0}\n{1}\n", s1.NameLib, s2.NameLib);
  }
}
