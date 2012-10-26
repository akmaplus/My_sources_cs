using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(300, 300);        //размер формы
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        Label label = new Label();  //новая метка - надпись на форме

                        Font fnt = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic);  //новый шрифт

                        label.AutoSize = true;                  //включить растягивание метки под текст
                        label.Text = "Здесь была Алисса";       //текст метки
                        label.Font = fnt;                       //шрифт метки
                        label.BackColor = Color.Aquamarine;     //фоновый цвет метки
                        label.ForeColor = Color.DarkMagenta;    //цвет шрифта метка
                        label.Location = new Point(10, 50);     //расположение метки на форме

                        this.Controls.Add(label);               //добавить в форму новый контрол - нашу метку label
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}