using System;

namespace Bookstore  // Набор классов для обслуживания книжного магазина:
{
   using System.Collections;

   // Описание книги в списке книг:
   public struct Book
   {
      public string Title;        // Название книги.
      public string Author;       // Автор книги.
      public decimal Price;       // Цена книги.
      public bool Paperback;      // Книга в бумажной обложке?

      public Book(string title, string author, decimal price, bool paperBack)
      {
         Title = title;
         Author = author;
         Price = price;
         Paperback = paperBack;
      }
   }
   
   public delegate void ProcessBookDelegate(Book book);   // Объявление типа делегата для обработки книги:
   
   public class BookDB   // Обслуживание базы данных книг.
   {
      ArrayList list = new ArrayList();    // Список всех книг в базе данных:

      // Добавление книги в базу данных:
      public void AddBook(string title, string author, decimal price, bool paperBack)
      {
         list.Add(new Book(title, author, price, paperBack));
      }

      // Вызов переданного делегата каждой книге в бумажной обложке для ее обработки: 
      public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
      {
         foreach (Book b in list) 
         {
            if (b.Paperback) processBook(b);  // Вызов делегата:
         }
      }
   }
}


namespace BookTestClient   // Использование классов книжного магазина:
{
   using Bookstore;
   
   class PriceTotaller   // Класс для общих и средних цен на книги:
   {
      int countBooks = 0;
      decimal priceBooks = 0.0m;

      internal void AddBookToTotal(Book book)
      {
         countBooks += 1;
         priceBooks += book.Price;
      }

      internal decimal AveragePrice()
      {
         return priceBooks / countBooks;
      }
   }



//////////////////////////////////////////////////////////////////////////////
   
   class Test  // Класс для тестирования базы данных книг:
   {
      static void PrintTitle(Book b)  // Печать названия книги.
      {
         Console.WriteLine("   {0}", b.Title);
      }

      
      static void Main() // Выполнение начинается здесь.
      {
         BookDB bookDB = new BookDB();

         
         AddBooks(bookDB);      // Инициализация базы данных с использованием нескольких книг:

         
         Console.WriteLine("Paperback Book Titles:");  // Печать названий всех книг в бумажной обложке:

         // Создание нового объекта делегата, связанного со статическим методом Test.PrintTitle:
         bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));

         // Получение средней цены книги в бумажной обложке при помощи объекта PriceTotaller:
         PriceTotaller totaller = new PriceTotaller();

         // Создание нового объекта-делегата, связанного с нестатическим объектом 
         // методом AddBookToTotal объекта суммарных показателей:
         bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));

         Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice() );
      }

      
      static void AddBooks(BookDB bookDB) // Инициализация базы данных книг с использованием  нескольких тестовых книг:
      {
         bookDB.AddBook("The C Programming Language",        "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
         bookDB.AddBook("The Unicode Standard 2.0",          "The Unicode Consortium", 39.95m, true);
         bookDB.AddBook("The MS-DOS Encyclopedia",           "Ray Duncan", 129.95m, false);
         bookDB.AddBook("Dogbert's Clues for the Clueless",  "Scott Adams", 12.00m, true);                                           
     }
   }
//////////////////////////////////////////////////////////////////////////////
}

