using System.Windows.Forms;   //минимальная аппликация

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