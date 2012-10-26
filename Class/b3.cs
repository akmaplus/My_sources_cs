using System;

namespace b3
{
    //класс - Персона
    class Person 
    {
   //видимость  тип   имя_свойства
        public  int     Id      { get; set; }   //автоматическое свойство

        public  string  Name    { get; set; }   //автоматическое свойство

        public  string  Address { get; set; }   //автоматическое свойство
    } 

    
    class Program
    {
        static void Main(string[] args)
        {
            //создаем экземпляр класса и присваиваем значения свойства класса, БЕЗ ИСПОЛЬЗОВАНИЯ КОНСТРУКТОРА!
            Person p = new Person() { Id = 1, Name = "Ben", Address = "Redmond, WA" }; 
        }
    }
}
