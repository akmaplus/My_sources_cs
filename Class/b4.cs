using System;
using System.Drawing;

namespace b4
{
    public class Vertex3d
    {
        // ���� 
        private double _x;
        private double _y;
        private double _z; 

        //����������� ���� - ��������� ������ ��� ���������� - �����
        private const string name = "Vertex";

        //���� ������ ��� ������ - ������ � ������������ ������
        private readonly int ver;

        //����������� �� ��������� ������
        public Vertex3d() 
        { 
            ver = 3; // ����� ����� ��������� ���. ��������
        }

        //����� ������
        public void SomeFunction()
        {
            //ver = 13;// ������!  - ����� ������
        }

        public int Ver { get { return ver; } }          //������ � ��������� �����

        public string Name { get { return name; } }     //������ � ��������� �����

        //����������� � �����������
        public Vertex3d(double x, double y, double z) 
        { 
            this._x = x; 
            this._y = y; 
            this._z = z; 
        } 

        //������ ����������� � �����������
        public Vertex3d(System.Drawing.Point point) 
            :this(point.X, point.Y, 0)                  //����� �� �������� ������ ����������� � ����������� - :this (��������� ������������)
        { 
            //����� - ��� ������ - ����
        } 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Vertex3d obj = new Vertex3d();

            Console.WriteLine( obj.Ver );       //������ ��������
            Console.WriteLine( obj.Name);
            Console.ReadKey();
        }
    }
}
