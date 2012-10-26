using System;

namespace b9
{
    //структура
    public struct Point
    {
        //поля структуры
        private Int32 _x;   
        private Int32 _y;
        
        //свойство структуры
        public Int32 X
        {
            get { return _x; }      //чтение
            set { _x = value; }     //запись
        }

        //свойство структуры
        public Int32 Y
        {
            get { return _y; }      //чтение
            set { _y = value; }     //запись
        }

        //конструктор структуры  - требование - обязательная инициализация полей структуры
        public Point(int x, int y)
        {
            _x = x;                 //инициализация поля
            _y = y;                 //инициализация поля
        }

        //public Point() { }                        // Запрещено! 

        //public Point(int x) { this._x = х; }      //Тоже запрещено! Отсутствует инициализация переменной _у 
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Point p;                            // Память выделяется, но переменная не инициализируется 
            p = new Point();                    // создаем экземпляр структуры
            p.X = 13;                           // доступ к полю структуры
            p.Y = 14;                           // доступ к полю структуры
            
            p = new Point();                    // p инициализируется 
            int x = p.X;                        // x будет равен нулю 

            //создание АНОНИМНОГО ТИПА - без имени!
            var part = new { ID = 1, Name = "PartOl", Weight = 2.5 };

            Console.WriteLine("var Part, Weight:    {0}", part.Weight       );  //печать поля анонимного типа
            Console.WriteLine("var Part, ToStringO: {0}", part.ToString()   );  //преобразовать его в строку
            Console.WriteLine("var Part, Type:      {0}", part.GetType()    );  //получить его тип

            Console.ReadKey();
        }
    }
}
