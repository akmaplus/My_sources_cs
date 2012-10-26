using System;

namespace Bookstore  // ����� ����ᮢ ��� ���㦨����� �������� ��������:
{
   using System.Collections;

   // ���ᠭ�� ����� � ᯨ᪥ ����:
   public struct Book
   {
      public string Title;        // �������� �����.
      public string Author;       // ���� �����.
      public decimal Price;       // ���� �����.
      public bool Paperback;      // ����� � �㬠���� �������?

      public Book(string title, string author, decimal price, bool paperBack)
      {
         Title = title;
         Author = author;
         Price = price;
         Paperback = paperBack;
      }
   }
   
   public delegate void ProcessBookDelegate(Book book);   // ������� ⨯� ������� ��� ��ࠡ�⪨ �����:
   
   public class BookDB   // ���㦨����� ���� ������ ����.
   {
      ArrayList list = new ArrayList();    // ���᮪ ��� ���� � ���� ������:

      // ���������� ����� � ���� ������:
      public void AddBook(string title, string author, decimal price, bool paperBack)
      {
         list.Add(new Book(title, author, price, paperBack));
      }

      // �맮� ��।������ ������� ������ ����� � �㬠���� ������� ��� �� ��ࠡ�⪨: 
      public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
      {
         foreach (Book b in list) 
         {
            if (b.Paperback) processBook(b);  // �맮� �������:
         }
      }
   }
}


namespace BookTestClient   // �ᯮ�짮����� ����ᮢ �������� ��������:
{
   using Bookstore;
   
   class PriceTotaller   // ����� ��� ���� � �।��� 業 �� �����:
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
   
   class Test  // ����� ��� ���஢���� ���� ������ ����:
   {
      static void PrintTitle(Book b)  // ����� �������� �����.
      {
         Console.WriteLine("   {0}", b.Title);
      }

      
      static void Main() // �믮������ ��稭����� �����.
      {
         BookDB bookDB = new BookDB();

         
         AddBooks(bookDB);      // ���樠������ ���� ������ � �ᯮ�짮������ ��᪮�쪨� ����:

         
         Console.WriteLine("Paperback Book Titles:");  // ����� �������� ��� ���� � �㬠���� �������:

         // �������� ������ ��ꥪ� �������, �易����� � ����᪨� ��⮤�� Test.PrintTitle:
         bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));

         // ����祭�� �।��� 業� ����� � �㬠���� ������� �� ����� ��ꥪ� PriceTotaller:
         PriceTotaller totaller = new PriceTotaller();

         // �������� ������ ��ꥪ�-�������, �易����� � ������᪨� ��ꥪ⮬ 
         // ��⮤�� AddBookToTotal ��ꥪ� �㬬���� ������⥫��:
         bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));

         Console.WriteLine("Average Paperback Book Price: ${0:#.##}", totaller.AveragePrice() );
      }

      
      static void AddBooks(BookDB bookDB) // ���樠������ ���� ������ ���� � �ᯮ�짮������  ��᪮�쪨� ��⮢�� ����:
      {
         bookDB.AddBook("The C Programming Language",        "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
         bookDB.AddBook("The Unicode Standard 2.0",          "The Unicode Consortium", 39.95m, true);
         bookDB.AddBook("The MS-DOS Encyclopedia",           "Ray Duncan", 129.95m, false);
         bookDB.AddBook("Dogbert's Clues for the Clueless",  "Scott Adams", 12.00m, true);                                           
     }
   }
//////////////////////////////////////////////////////////////////////////////
}

