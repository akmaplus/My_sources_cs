using System.Windows.Forms;   //�������쭠� ���������

public class MainWindow : Form
{
  public MainWindow()
        : base()
                     {
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}