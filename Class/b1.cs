using System;

namespace b1
{
    class Vertex3D
    {
        //(закрытые) поля класса (данные)
        private double _x;
        private double _y;
        private double _z;

        //свойства класса
        public double X
        {
            get { return _x;  } //метод get
            set { _x = value; } //метод set
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

        //метод класса
        public void SetToOrigin()
        {
            X = Y = Z = 0.0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vertex3D obj = new Vertex3D(); //создаем класс

            obj.SetToOrigin();      //вызываем метод класса

            obj.X = 13.0;       //присв. свойствам класса - значение
        }
    }
}
