using System;
namespace MyCollections{
                           using System.Collections;
   
   public delegate void ChangedEventHandler(object sender, EventArgs e);   // Тип делегата для обработки уведомлений об изменении.


   public class ListWithChangedEvent: ArrayList  // Класс, работающий аналогично ArrayList, но посылающий уведомления о событии при любых изменениях списка.
   {
      public event ChangedEventHandler Changed;    // Событие, с помощью которого клиенты могут получать уведомления о любых изменениях элементов списка.
      
      protected virtual void OnChanged(EventArgs e) {   if (Changed != null)          // Вызов события Changed; вызывается при каждом изменении списка
                                                        Changed(this, e);
                                                    }

      public override int Add(object value)         {   int i = base.Add(value);      // Переопределение некоторых методов, которые могут изменить список; 
                                                        OnChanged(EventArgs.Empty);   // вызов события после каждого
                                                        return i;
                                                    }

      public override void Clear()                  {   base.Clear();
                                                        OnChanged(EventArgs.Empty);
                                                    }

      public override object this[int index]        {
                                                        set 
                                                        {
                                                          base[index] = value;
                                                          OnChanged(EventArgs.Empty);
                                                        }
                                                    }
   }
}


namespace TestEvents{
                          using MyCollections;

   class EventListener 
   {
      private ListWithChangedEvent List;

      public EventListener(ListWithChangedEvent list){  List = list;
                                                        // добавления "ListChanged" к событию Changed для "List".
                                                        List.Changed += new ChangedEventHandler(ListChanged);
                                                     }

      private void ListChanged(object sender, EventArgs e){ // Этот вызов будет выполняться при любых изменениях списка.
                                                            Console.WriteLine("This is called when the event fires.");
                                                          }
      public void Detach(){ // Отсоединение события и удаление списка
                            List.Changed -= new ChangedEventHandler(ListChanged);
                            List = null;
                          }
   }

   class Test 
   {
      public static void Main(){ // Тестирование класса ListWithChangedEvent.
      
        ListWithChangedEvent list = new ListWithChangedEvent();   // Создание нового списка.

      
        EventListener listener = new EventListener(list);    // Создание класса, ожидающего событий изменения списка.

      
        list.Add("item 1");  // Добавление и удаление элементов списка.
        list.Clear();
        listener.Detach();
                             }
   }
}

