using System;
using System.Drawing;

namespace b4
{
    public class Vertex3d
    {
        // Поля 
        private double _x;
        private double _y;
        private double _z; 

        //константное поле - установка только при объявлении - здесь
        private const string name = "Vertex";

        //поле только для чтения - только в конструкторе класса
        private readonly int ver;

        //конструктор по умолчанию класса
        public Vertex3d() 
        { 
            ver = 3; // здесь можно присвоить люб. значение
        }

        //метод класса
        public void SomeFunction()
        {
            //ver = 13;// Ошибка!  - здесь нельзя
        }

        public int Ver { get { return ver; } }          //доступ к константе извне

        public string Name { get { return name; } }     //доступ к константе извне

        //конструктор с параметрами
        public Vertex3d(double x, double y, double z) 
        { 
            this._x = x; 
            this._y = y; 
            this._z = z; 
        } 

        //второй конструктор с параметрами
        public Vertex3d(System.Drawing.Point point) 
            :this(point.X, point.Y, 0)                  //здесь мы вызываем первый конструктор с параметрами - :this (сигнатура конструктора)
        { 
            //пусто - код вызова - выше
        } 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Vertex3d obj = new Vertex3d();

            Console.WriteLine( obj.Ver );       //печать констант
            Console.WriteLine( obj.Name);
            Console.ReadKey();
        }
    }
}
