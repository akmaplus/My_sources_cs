using System;

namespace b2
{
    class Vertex3d
    {
        //(��������) ���� ������ (������)
        private double _x = 0;   //����� ����� ��������� ����������� ������������� ������, 
        private double _y = 0;   //����� ��� ����� ������� � ����������� ������������ static
        private double _z = 0;   //����� � ���� - �������, ��� � ������������

        //�������� ������
        public double X
        {
            get { return _x; } //����� get
            set { _x = value; } //����� set
        }

        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }

        //����� ������
        public void SetToOrigin()
        {
            X = Y = Z = 0.0;
        }

        //����������� ����� - ��� ������� - ��������� ��� ���� � �����
        public static Vertex3d Add(Vertex3d a, Vertex3d b) //������� ��� �������
        {
            Vertex3d result = new Vertex3d();   //����� ���. ������

            result.X = a.X + b.X;  //���������� ������� � ��������. �������. ������
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;

            return result; //�����. ����� ��� ���������
        }

        //����������� (������) �� ���������
        public Vertex3d()
        {
            _x = _y = _z = 0.0;
        }

        //����������� (������) � ����������� (�����������������)
        public Vertex3d(double x, double y, double z) 
        { 
            this._x = x; 
            this._y = y; 
            this._z = z; 
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vertex3d a = new Vertex3d(0, 0, 1);     //������� ��������� ������ - ������

            Vertex3d b = new Vertex3d(1, 0, 1);     //������� ��������� ������ - ������

            Vertex3d sum = Vertex3d.Add(a, b);      //�������� ����������� ����� ������

        }
    }
}
