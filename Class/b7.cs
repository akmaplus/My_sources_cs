using System;

namespace b7
{   
    //������� �����
    class Base 
    { 
        //����������� ����� �������� ������
        public virtual void DoSomethingVirtual() 
        { 
            Console.WriteLine("Base.DoSomethingVirtual"); 
        } 

        //����� �������� ������ - �������
        public void DoSomethingNonVirtual() 
        { 
            Console.WriteLine("Base.DoSomethingNonVirtual"); 
        } 
    } 

    //����������� �����
    class Derived : Base 
    { 
        //���������������� ����� ������������ ������
        public override void DoSomethingVirtual() 
        { 
            Console.WriteLine("Derived.DoSomethingVirtual"); 
        }

        //���������� (new) ����� ������������ ������  - ���������� ������ ����� ��������� ����� (������������������) ������
        public new void DoSomethingNonVirtual() 
        { 
            Console.WriteLine("Derived.DoSomethingNonVirtual"); 
        } 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Derived via Base reference:\n");
            Base baseRef = new Derived();                           //������� ����������� ����� � ��������� �������� ������

            baseRef.DoSomethingVirtual();                           //�������� ����������� �����
            baseRef.DoSomethingNonVirtual();                        //�������� ������� �����
            
            Console.WriteLine("\n\nDerived via Derived reference:\n");
            Derived derivedRef = new Derived();                     //������� ����������� ����� � ��������� ������������ ������

            derivedRef.DoSomethingVirtual();                        //�������� ����������� �����
            derivedRef.DoSomethingNonVirtual();                     //�������� ������� �����
            Console.ReadKey();

        }
    }
}
