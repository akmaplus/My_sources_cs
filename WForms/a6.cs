using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    { 
                        this.Size = new Size(300, 300);  //������ ������ �����

                        this.Name = "MainWindow";
                        this.Text = "����";
                        this.MaximizeBox = false; 
                                                                           
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        //���������� ���������� ������� - ����������
                        this.Paint += new PaintEventHandler(this.Form1_Paint);  //System.Windows.Forms.PaintEventHandler
                     }

  //���������� ������� - ���������� ����������� ����� �� ������
  private void Form1_Paint(object sender, PaintEventArgs e)
  {
    Font fnt = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic);  //����� �����
    Brush brush = new SolidBrush( Color.Blue );                             //����� �����
    System.Drawing.Pen pen = new Pen(Color.Gold, 2);                        //����� ����

    //�������� ������� ��������� ��������� ������, ������ ���
    e.Graphics.Clear(Color.LightPink);

    //������ ��������������
    e.Graphics.DrawRectangle(pen, new Rectangle(1, 1, 100, 100));
    e.Graphics.DrawRectangle(pen, 101, 101, 150, 150);
    e.Graphics.FillRectangle(brush, 50, 50, 50, 50);

    //������ �����
    e.Graphics.DrawLine(pen, 1,1, 100, 100);
 
    //������ �����
    e.Graphics.DrawString("Hello",  fnt, brush, new PointF(1, 1));
    e.Graphics.DrawString("Hi",     fnt, brush, new PointF(100, 100));
    e.Graphics.DrawString("������", fnt, brush, 150.0f, 150.0f);
  }

}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}