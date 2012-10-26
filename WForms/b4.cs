using System;
using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{
  private StatusStrip ssInfo = new StatusStrip();
  private ToolStripStatusLabel sslLabel1 = new ToolStripStatusLabel();
  private ToolStripStatusLabel sslLabel2 = new ToolStripStatusLabel();
  private ToolStripStatusLabel sslLabel3 = new ToolStripStatusLabel();
  private Label lbl = new Label();

  public MainWindow()
          : base()
                    {     Size = new Size(500, 400);   //������ �����
                          FormBorderStyle = FormBorderStyle.FixedSingle;
                          MaximizeBox = false;

                          lbl.AutoSize    = false;                       //��������� ����������!
                          lbl.Text        = "��������";
                          lbl.BorderStyle = BorderStyle.Fixed3D;
                          lbl.BackColor   = Color.Aqua;                 //������ ���� ���� �����
                          lbl.Location    = new Point(10,10);
                          lbl.TextAlign   = ContentAlignment.MiddleCenter;
                          lbl.Font        = new Font("Times New Roman", 27.75F, ((FontStyle)((FontStyle.Bold | FontStyle.Italic))), GraphicsUnit.Point, ((byte)(204)));

                          //��������� �� ��� ����������� �����
                          lbl.Dock = DockStyle.Fill;     //Top Right None Left Bottom
                          
                          Controls.Add(lbl);  //�������� ����� ����� �� �����

                          sslLabel1.Size = new Size(200, 17);  sslLabel1.Name = "sslLabel"; sslLabel1.Text = "��������!"; 
                          sslLabel2.Size = new Size(150, 17);  sslLabel2.Name = "sslLabel"; sslLabel2.Text = "���, ����������!";
                          sslLabel3.Size = new Size(60, 17);   sslLabel3.Name = "sslLabel"; sslLabel3.Text = "��������!";  

                          sslLabel1.AutoSize  = false; 
                          sslLabel2.AutoSize  = false;  

                          ssInfo.Items.AddRange(new ToolStripItem[] { sslLabel1, sslLabel2, sslLabel3} );

                          //����, ������������� �� ������ ������
                          //ssInfo.Location  = new Point(0, 244);  
                          //ssInfo.Size = new Size(292, 22); ssInfo.Name = "ssInfo"; ssInfo.Text = "ssInfo";

                          lbl.Click  += new EventHandler(lbl_Click);

                          Controls.Add(ssInfo);

                          PerformLayout();      //���������� ��������� �����
                     }

        private void lbl_Click(object sender, EventArgs e){  MessageBox.Show("������"); }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}