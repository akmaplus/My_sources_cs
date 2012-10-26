using System;
namespace MyCollections{
                           using System.Collections;
   
   public delegate void ChangedEventHandler(object sender, EventArgs e);   // “ип делегата дл€ обработки уведомлений об изменении.


   public class ListWithChangedEvent: ArrayList  //  ласс, работающий аналогично ArrayList, но посылающий уведомлени€ о событии при любых изменени€х списка.
   {
      public event ChangedEventHandler Changed;    // —обытие, с помощью которого клиенты могут получать уведомлени€ о любых изменени€х элементов списка.
      
      protected virtual void OnChanged(EventArgs e) {   if (Changed != null)          // ¬ызов событи€ Changed; вызываетс€ при каждом изменении списка
                                                        Changed(this, e);
                                                    }

      public override int Add(object value)         {   int i = base.Add(value);      // ѕереопределение некоторых методов, которые могут изменить список; 
                                                        OnChanged(EventArgs.Empty);   // вызов событи€ после каждого
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
                                                        // добавлени€ "ListChanged" к событию Changed дл€ "List".
                                                        List.Changed += new ChangedEventHandler(ListChanged);
                                                     }

      private void ListChanged(object sender, EventArgs e){ // Ётот вызов будет выполн€тьс€ при любых изменени€х списка.
                                                            Console.WriteLine("This is called when the event fires.");
                                                          }
      public void Detach(){ // ќтсоединение событи€ и удаление списка
                            List.Changed -= new ChangedEventHandler(ListChanged);
                            List = null;
                          }
   }

   class Test 
   {
      public static void Main(){ // “естирование класса ListWithChangedEvent.
      
        ListWithChangedEvent list = new ListWithChangedEvent();   // —оздание нового списка.

      
        EventListener listener = new EventListener(list);    // —оздание класса, ожидающего событий изменени€ списка.

      
        list.Add("item 1");  // ƒобавление и удаление элементов списка.
        list.Clear();
        listener.Detach();
                             }
   }
}

