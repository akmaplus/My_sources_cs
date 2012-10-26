using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{  
  Label lbl = new Label();    //все! элементы доступные напрямую с формы должны быть объявлены здесь, иначе ниже не прокатит

  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(300, 300);        //размер формы
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        lbl.Name = "lbl";

                        Font fnt = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic);  //новый шрифт

                        lbl.AutoSize = true;                  //включить растягивание метки под текст
                        lbl.Text = "Здесь была Алисса";       //текст метки
                        lbl.Font = fnt;                       //шрифт метки
                        lbl.BackColor = Color.Aquamarine;     //фоновый цвет метки
                        lbl.ForeColor = Color.DarkMagenta;    //цвет шрифта метка
                        lbl.Location = new Point(10, 50);     //расположение метки на форме

                        this.Controls.Add(lbl);               //добавить в форму новый контрол - метку lbl

                        this.lbl.MouseMove += new MouseEventHandler(this.lbl_MouseMove);  //подключить обработчик события мыши
                     }

                     //обработчик события - Движение мыши
                     private void lbl_MouseMove(object sender, MouseEventArgs e)
                     {
                        this.Text = string.Format("x:{0} y:{1}", e.X, e.Y);
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}