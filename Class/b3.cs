using System;

namespace b3
{
    //����� - �������
    class Person 
    {
   //���������  ���   ���_��������
        public  int     Id      { get; set; }   //�������������� ��������

        public  string  Name    { get; set; }   //�������������� ��������

        public  string  Address { get; set; }   //�������������� ��������
    } 

    
    class Program
    {
        static void Main(string[] args)
        {
            //������� ��������� ������ � ����������� �������� �������� ������, ��� ������������� ������������!
            Person p = new Person() { Id = 1, Name = "Ben", Address = "Redmond, WA" }; 
        }
    }
}
