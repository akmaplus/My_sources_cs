using System;
namespace MyCollections 
{
   using System.Collections;

   // �����, ���������� ���������� ArrayList, �� ���������� ����������� � �������
   // ��� ����� ���������� ������. 
   public class ListWithChangedEvent: ArrayList 
   {
      // �������, � ������� �������� ������� ����� �������� �����������
      // � ����� ���������� ��������� ������.
      public event EventHandler Changed;

      // ����� ������� Changed; ���������� ��� ������ ��������� ������
      protected virtual void OnChanged(EventArgs e) 
      {
         if (Changed != null)
            Changed(this,e);
      }

      // ��������������� ��������� �������, ������� ����� �������� ������;
      // ����� ������� ����� �������:
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
         // ���������� "ListChanged" � ������� Changed ��� "List".
         List.Changed += new EventHandler(ListChanged);
      }

      // ����� ����� ����������� ��� ����� ���������� ������.
      private void ListChanged(object sender, EventArgs e) 
      {
         Console.WriteLine("This is called when the event fires.");
      }

      public void Detach() 
      {
         // ������������ ������� � �������� ������
         List.Changed -= new EventHandler(ListChanged);
         List = null;
      }
   }

   class Test 
   {
      // ������������ ������ ListWithChangedEvent.
      public static void Main() 
      {
      // �������� ������ ������.
      ListWithChangedEvent list = new ListWithChangedEvent();

      // �������� ������, ���������� ������� ��������� ������.
      EventListener listener = new EventListener(list);

      // ���������� � �������� ��������� ������.
      list.Add("item 1");
      list.Clear();
      listener.Detach();
      }
   }
}

