using System;
using System.Windows.Forms;

public class HelloMessage
{

  protected string _msg = "hi";
  private static string _msg2 = "hi";


  public void Speak()  //��⮤ �����
  {
    MessageBox.Show(_msg);
  }

  public void Speak2()  //��⮤ �����
  {
    MessageBox.Show(_msg2);
  }


  public HelloMessage() //���������
  {

  }

  
  public string Test   //�㡫�筮� ᢮��⢠ �����
  {
      get { return _msg; }   //��⮤ get
      set { _msg = value; }  //��⮤ set
  }

  public static void Say()
  {
    MessageBox.Show(_msg2);
  }

  public string Test2   //�㡫�筮� ᢮��⢮ �����
  {
      get { return _msg2; }   //��⮤ get
      set { _msg2 = value; }  //��⮤ set
  }

  public static string Test3   //����᪮� �㡫�筮� ᢮��⢮ �����
  {
      get { return _msg2; }   //��⮤ get
      set { _msg2 = value; }  //��⮤ set
  }


}
