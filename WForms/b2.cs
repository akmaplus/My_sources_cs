using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{
  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(300, 300);        //������ �����
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        try { this.Icon = new Icon("App.ico"); } catch {}     //���������� ������ �� ���������

                        Label lbl = new Label();  //����� ����� - ������� �� �����
                        lbl.Name = "lbl";         //���� ��� �����

                        Font fnt = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic);  //����� �����

                        lbl.AutoSize = true;                  //�������� ������������ ����� ��� �����
                        lbl.Text = "����� ���� ������";       //����� �����
                        lbl.Font = fnt;                       //����� �����
                        lbl.BackColor = Color.Aquamarine;     //������� ���� �����
                        lbl.ForeColor = Color.DarkMagenta;    //���� ������ �����
                        lbl.Location = new Point(10, 50);     //������������ ����� �� �����

                        this.Controls.Add(lbl);               //�������� � ����� ����� ������� - ���� ����� label

                        //����������� ����������� ������� - �������� ����

                        //this.Controls[0].MouseMove += new MouseEventHandler(this.lbl_MouseMove);    //�� ������� ��������

                        this.Controls["lbl"].MouseMove += new MouseEventHandler(this.lbl_MouseMove);  //�� ����� ��������
                     }

                     //���������� ������� - �������� ����
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