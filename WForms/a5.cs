using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   //в предыдущих примерах не было указано слово this - неообязательно, без него неясен смысл присваиваний

                        this.Size = new System.Drawing.Size(300, 300);  //задаем размер формы

                        this.Name = "MainWindow";
                        this.Text = "Тест";
                        this.MaximizeBox = false; 
                                                                           
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        //задаем цвет формы, задний и лицевой цвет
                        this.BackColor = System.Drawing.Color.Aqua;
                        this.ForeColor = System.Drawing.Color.Blue;
                        //this.BackColor = System.Drawing.SystemColors.Control;  //системные цвета
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}