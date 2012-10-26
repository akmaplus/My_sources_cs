using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   //в предыдущих примерах не было указано слово this - неообязательно, без него неясен смысл присваиваний

                        //this.ClientSize          = new System.Drawing.Size(422, 114);
                        this.Size = new System.Drawing.Size(300, 300);  //задаем размер формы

                        this.Name = "MainWindow";
                        this.Text = "Тест";
                        this.MaximizeBox = false; 
                                                                            //формат границ формы:
                        this.FormBorderStyle = FormBorderStyle.FixedSingle; //SizableToolWindow Sizable None FixedToolWindow FixedDialog Fixed3D

                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}