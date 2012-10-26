using System;

namespace b6
{
    class Program
    {
        //������� ����� - ��������
        public class Base 
        {
            //���� �������� ������
            protected Int32 _x;       //���������� ���� - �������� �� ������������ ������

            //����������� �������� �������� ������
            public virtual Int32 MyProperty 
            { 
                get { return _x; }      //��������� �������� ���������� ����
            } 

            //����������� ����� �������� ������
            public virtual void DoSomething() 
            { 
                _x = 13;                                    //����������� ��������� 13
                Console.WriteLine("Base.DoSomething");      //������ ��������� �������� ������
            } 
        } 

        //����������� ����� - ��������
        public class Derived : Base 
        { 
            //���������������� �������� �������� ������
            public override Int32 MyProperty 
            {
                get { return _x * 2; }  //��������� ��������� �������� ���������� ����
            }

            //���������������� ����� �������� ������
            public override void DoSomething() 
            {
                _x = 14;                                    //����������� ��������� 14
                base.DoSomething();                         //����� ������ �������� ������
                Console.WriteLine("Derived.DoSomething");   //������ ��������� ������������ ������
            } 
        } 

        static void Main(string[] args)
        {
            Base d = new Derived();     //������� ��������� ������������ ������ - � ���������� �������� ������ !!

            d.DoSomething();            //�������� ����� ������������ ������ - (�� �������������)

            Console.WriteLine( d.MyProperty );  //������ � �������� ������������ ������ - (��������������)
            Console.ReadKey();
        }
    }
}
