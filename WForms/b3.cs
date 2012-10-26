using System;
using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{  
  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(525, 340);        //размер формы
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                        this.MaximizeBox = false;

                        for(int row=10; row>0;  row--)  //генерируем кучу меток, в виде строк-колонок
                        for(int col=10; col>0;  col--)
                        {
                          Label lbl = new Label();
                          lbl.AutoSize = true; 
                          lbl.Text = string.Format("{0,5}:{1,-5}", row, col);  //параметр, [выравнивание] длина поля
                          lbl.BorderStyle = BorderStyle.Fixed3D;
                          lbl.Location = new Point((50*col)-40, (30*row)-20);
                          
                          this.Controls.Add(lbl);  //добавить новую метку на форму

                          //назначаем обработчик события - Клик по метке
                          lbl.Click += new System.EventHandler(this.lbl_Click);
                        }
                     }
        //обработчик события - Клик по метке
        private void lbl_Click(object sender, EventArgs e)
        {
           Label s = (Label)sender; //получаем источник события - метку

           this.Text = string.Format("{0}", s.Text );  //получаем текст метки, т.к. имена меток выставлены не были
           s.BackColor = Color.Aqua;   //меняем цвет фона метки
        }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}