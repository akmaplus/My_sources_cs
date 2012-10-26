using System;
using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{  
  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(525, 340);        //������ �����
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;
                        this.MaximizeBox = false;

                        for(int row=10; row>0;  row--)  //���������� ���� �����, � ���� �����-�������
                        for(int col=10; col>0;  col--)
                        {
                          Label lbl = new Label();
                          lbl.AutoSize = true; 
                          lbl.Text = string.Format("{0,5}:{1,-5}", row, col);  //��������, [������������] ����� ����
                          lbl.BorderStyle = BorderStyle.Fixed3D;
                          lbl.Location = new Point((50*col)-40, (30*row)-20);
                          
                          this.Controls.Add(lbl);  //�������� ����� ����� �� �����

                          //��������� ���������� ������� - ���� �� �����
                          lbl.Click += new System.EventHandler(this.lbl_Click);
                        }
                     }
        //���������� ������� - ���� �� �����
        private void lbl_Click(object sender, EventArgs e)
        {
           Label s = (Label)sender; //�������� �������� ������� - �����

           this.Text = string.Format("{0}", s.Text );  //�������� ����� �����, �.�. ����� ����� ���������� �� ����
           s.BackColor = Color.Aqua;   //������ ���� ���� �����
        }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}