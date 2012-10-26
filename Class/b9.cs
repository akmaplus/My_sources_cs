using System;

namespace b9
{
    //���������
    public struct Point
    {
        //���� ���������
        private Int32 _x;   
        private Int32 _y;
        
        //�������� ���������
        public Int32 X
        {
            get { return _x; }      //������
            set { _x = value; }     //������
        }

        //�������� ���������
        public Int32 Y
        {
            get { return _y; }      //������
            set { _y = value; }     //������
        }

        //����������� ���������  - ���������� - ������������ ������������� ����� ���������
        public Point(int x, int y)
        {
            _x = x;                 //������������� ����
            _y = y;                 //������������� ����
        }

        //public Point() { }                        // ���������! 

        //public Point(int x) { this._x = �; }      //���� ���������! ����������� ������������� ���������� _� 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Point p;                            // ������ ����������, �� ���������� �� ���������������� 
            p = new Point();                    // ������� ��������� ���������
            p.X = 13;                           // ������ � ���� ���������
            p.Y = 14;                           // ������ � ���� ���������
            
            p = new Point();                    // p ���������������� 
            int x = p.X;                        // x ����� ����� ���� 

            //�������� ���������� ���� - ��� �����!
            var part = new { ID = 1, Name = "PartOl", Weight = 2.5 };

            Console.WriteLine("var Part, Weight:    {0}", part.Weight       );  //������ ���� ���������� ����
            Console.WriteLine("var Part, ToStringO: {0}", part.ToString()   );  //������������� ��� � ������
            Console.WriteLine("var Part, Type:      {0}", part.GetType()    );  //�������� ��� ���

            Console.ReadKey();
        }
    }
}
