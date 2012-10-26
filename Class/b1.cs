using System;

namespace b1
{
    class Vertex3D
    {
        //(��������) ���� ������ (������)
        private double _x;
        private double _y;
        private double _z;

        //�������� ������
        public double X
        {
            get { return _x;  } //����� get
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vertex3D obj = new Vertex3D(); //������� �����

            obj.SetToOrigin();      //�������� ����� ������

            obj.X = 13.0;       //�����. ��������� ������ - ��������
        }
    }
}
