using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   //� ���������� �������� �� ���� ������� ����� this - ��������������, ��� ���� ������ ����� ������������

                        this.Size = new System.Drawing.Size(300, 300);  //������ ������ �����

                        this.Name = "MainWindow";
                        this.Text = "����";
                        this.MaximizeBox = false; 
                                                                           
                        this.FormBorderStyle = FormBorderStyle.FixedSingle;

                        //������ ���� �����, ������ � ������� ����
                        this.BackColor = System.Drawing.Color.Aqua;
                        this.ForeColor = System.Drawing.Color.Blue;
                        //this.BackColor = System.Drawing.SystemColors.Control;  //��������� �����
                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}