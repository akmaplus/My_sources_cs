using System;

namespace b2
{
    class Vertex3d
    {
        //(закрытые) поля класса (данные)
        private double _x = 0;   //здесь можно выполнить статическую инициализацию данных, 
        private double _y = 0;   //также это можно сделать в статическом конструкторе static
        private double _z = 0;   //метод в коде - быстрее, чем в конструкторе

        //свойства класса
        public double X
        {
            get { return _x; } //метод get
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

        //статический метод - как функция - действует для типа в целом
        public static Vertex3d Add(Vertex3d a, Vertex3d b) //сложить две вершины
        {
            Vertex3d result = new Vertex3d();   //новый экз. класса

            result.X = a.X + b.X;  //складываем вершины и присваив. свойств. класса
            result.Y = a.Y + b.Y;
            result.Z = a.Z + b.Z;

            return result; //возвр. класс как результат
        }

        //конструктор (класса) по умолчанию
        public Vertex3d()
        {
            _x = _y = _z = 0.0;
        }

        //конструктор (класса) с параметрами (параметризованный)
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
            Vertex3d a = new Vertex3d(0, 0, 1);     //создаем экзмепляр класса - объект

            Vertex3d b = new Vertex3d(1, 0, 1);     //создаем экзмепляр класса - объект

            Vertex3d sum = Vertex3d.Add(a, b);      //вызываем статический метод класса

        }
    }
}
