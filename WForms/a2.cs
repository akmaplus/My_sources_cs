using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {
                        ClientSize          = new System.Drawing.Size(422, 114);
                        Name = "MainWindow";
                        Text = "Тест";
                    }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}