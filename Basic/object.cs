using System;
// Резюмируя - класс System.Object предоставляет основу шаблон все остальных классов функционирующих в CLR
// основная поставка класса - методы по работе с шаблоном заготовкой, проверка на равенство ссылок, 
// равенство внутреннего содержания, вид строчного представления объекта и другие. Все эти методы переопределяемы в потомках!

class Point // класс Point производный от System.Object
{
    public int x, y;   //публичные поля класса

    //конструктор
    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }

    //переопределение метода - сравнение внутренних полей объектов
    public override bool Equals(object obj) 
    {
        if ( obj.GetType() != this.GetType() ) return false;  // возратить ложь - если ссылка на объект отличного от нашего типа
        
        Point other = (Point) obj;  //преобразуем к нашему типу

        return (this.x == other.x) && (this.y == other.y);  // возратить истину - если публичные поля объектов равнозначны
    }
    
    //переопределение метода
    public override int GetHashCode() // возрат хэш код объекта
    {
        return x ^ y;
    }

    //переопределение метода
    public override String ToString()  // возрат в текстовом(символьном) представлении
    {
        return String.Format("({0}, {1})", x, y);
    }

    
    public Point Copy()   // возратить копию объекта - путем простого клонирования членов объекта
    {
        return (Point) this.MemberwiseClone();
    }
}



public sealed class App 
{
    static void Main() 
    {
        Point p1 = new Point(1,2);      // создаем объект Point

        Point p2 = p1.Copy();           // создаем копию первого объекта 
       
        Point p3 = p1;                  // создаем ссылку на первый объект

        
        Say("{0}\n", Object.ReferenceEquals(p1, p2));   // если ссылки неравны
        
        Say("{0}\n", Object.Equals(p1, p2));            // если объекты равны
        
        Say("{0}\n", Object.ReferenceEquals(p1, p3));   // если ссылки равны
        
        Say("p1's value is: {0}\n", p1.ToString());     // печать объект в строчном виде: (1, 2)
    }

   static void Say(string prm, params object[] prms){  //форматная печать на консоль
     System.Console.Write(prm, prms);               }
}

// This code example produces the following output:
//
// False
// True
// True
// p1's value is: (1, 2)
//