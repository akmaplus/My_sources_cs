using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   this.Size = new System.Drawing.Size(300, 300);        //������ �����
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        Label label = new Label();  //����� ����� - ������� �� �����

                        Font fnt = new Font("Verdana", 16, FontStyle.Bold | FontStyle.Italic);  //����� �����

                        label.AutoSize = true;                  //�������� ������������ ����� ��� �����
                        label.Text = "����� ���� ������";       //����� �����
                        label.Font = fnt;                       //����� �����
                        label.BackColor = Color.Aquamarine;     //������� ���� �����
                        label.ForeColor = Color.DarkMagenta;    //���� ������ �����
                        label.Location = new Point(10, 50);     //������������ ����� �� �����

                        this.Controls.Add(label);               //�������� � ����� ����� ������� - ���� ����� label
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}