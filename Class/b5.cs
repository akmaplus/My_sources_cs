using System;

namespace b5
{
    class Program
    {
        //������� ����� - ��������
        public class BaseClass 
        { 
            //���� ������
            private     int _a;     //�������� ����
            protected   int _b;     //���������� ���� (��������� � ������ � ����������� �������)
            public      int _c;     //��������� ����

            //����������� �������� ������
            public BaseClass(int x, int y, int z)
            {
            }

        } 

        //�������� (�����������) ����� - ��������
        public class DerivedClass : BaseClass       //����� ��������� : ��������� ������������ �����
        { 
            //����������� �� ��������� - ������������ ������
            public DerivedClass()
                : base(1, 2, 3)         //����� ������������ �������� ������ - ����� ��������� ����� : base
            { 
                //_a = 1;       // ��� ������! ���������� ����� ����������� private � BaseClass 
                _b = 2;         // ok 
                _c = 3;         // �� 
} 
            //����� ������������ ������
            public void DoSomething() 
            { 
                _c = _b = 99;   //������ � ����� ������������� ������
            } 
        } 

        static void Main(string[] args)
        {
        }
    }
}
