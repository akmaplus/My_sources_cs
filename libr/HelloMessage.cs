using System;
using System.Windows.Forms;

public class HelloMessage
{

  protected string _msg = "hi";
  private static string _msg2 = "hi";


  public void Speak()  //метод класса
  {
    MessageBox.Show(_msg);
  }

  public void Speak2()  //метод класса
  {
    MessageBox.Show(_msg2);
  }


  public HelloMessage() //конструктор
  {

  }

  
  public string Test   //публичное свойства класса
  {
      get { return _msg; }   //метод get
      set { _msg = value; }  //метод set
  }

  public static void Say()
  {
    MessageBox.Show(_msg2);
  }

  public string Test2   //публичное свойство класса
  {
      get { return _msg2; }   //метод get
      set { _msg2 = value; }  //метод set
  }

  public static string Test3   //статическое публичное свойство класса
  {
      get { return _msg2; }   //метод get
      set { _msg2 = value; }  //метод set
  }


}
