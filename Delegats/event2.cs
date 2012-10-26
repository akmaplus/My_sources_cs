using System;
namespace MyCollections 
{
   using System.Collections;

   //  ласс, работающий аналогично ArrayList, но посылающий уведомлени€ о событии
   // при любых изменени€х списка. 
   public class ListWithChangedEvent: ArrayList 
   {
      // —обытие, с помощью которого клиенты могут получать уведомлени€
      // о любых изменени€х элементов списка.
      public event EventHandler Changed;

      // ¬ызов событи€ Changed; вызываетс€ при каждом изменении списка
      protected virtual void OnChanged(EventArgs e) 
      {
         if (Changed != null)
            Changed(this,e);
      }

      // ѕереопределение некоторых методов, которые могут изменить список;
      // вызов событи€ после каждого:
      public override int Add(object value) 
      {
         int i = base.Add(value);
         OnChanged(EventArgs.Empty);
         return i;
      }

      public override void Clear() 
      {
         base.Clear();
         OnChanged(EventArgs.Empty);
      }

      public override object this[int index] 
      {
         set 
         {
            base[index] = value;
            OnChanged(EventArgs.Empty);
         }
      }
   }
}

namespace TestEvents 
{
   using MyCollections;

   class EventListener 
   {
      private ListWithChangedEvent List;

      public EventListener(ListWithChangedEvent list) 
      {
         List = list;
         // добавлени€ "ListChanged" к событию Changed дл€ "List".
         List.Changed += new EventHandler(ListChanged);
      }

      // ¬ызов будет выполн€тьс€ при любых изменени€х списка.
      private void ListChanged(object sender, EventArgs e) 
      {
         Console.WriteLine("This is called when the event fires.");
      }

      public void Detach() 
      {
         // ќтсоединение событи€ и удаление списка
         List.Changed -= new EventHandler(ListChanged);
         List = null;
      }
   }

   class Test 
   {
      // “естирование класса ListWithChangedEvent.
      public static void Main() 
      {
      // —оздание нового списка.
      ListWithChangedEvent list = new ListWithChangedEvent();

      // —оздание класса, ожидающего событий изменени€ списка.
      EventListener listener = new EventListener(list);

      // ƒобавление и удаление элементов списка.
      list.Add("item 1");
      list.Clear();
      listener.Detach();
      }
   }
}

