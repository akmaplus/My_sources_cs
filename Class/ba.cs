using System;

namespace ba
{
    //����������� �����
    public abstract class MyClass 
    { 
        //����������� ����� (������������ ������)
        public abstract void DoSomething(); 
    } 

    //����������� �����
    public class MyDerivedClass : MyClass 
    {
        //���������� ������������ ������ (��) - ����������������� ���� ��� ������ ������
        //public override void DoSomething()
        //{
        //}
    } 

    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myClass = new MyClass();              // ���������! ������ ������� ��������� ������������ ������ (��)

            MyClass myClass = new MyDerivedClass () ;       // ������� ��������� ������������ ������

            //myClass.DoSomething();                        //������ - �.�. �� ��� ���������� ����������� �����(��)
        }
    }
}
