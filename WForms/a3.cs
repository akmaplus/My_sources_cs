using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {
                        ClientSize          = new System.Drawing.Size(422, 114);
                        Name = "MainWindow";
                        Text = "����";
                        MaximizeBox = false;    //��������� ������ - ���������� � 
                        MinimizeBox = false;    //��������, � ��������� ����
                        ShowIcon = false;       //��������� ����� ������ ����������
                        HelpButton = true;      //��������� ����� ������ ������� � ��������� ����
                        ShowInTaskbar = false;  //��������� ��������� �� ������ �����
                        TopMost = true;         //���������� ���� ������ ���� ����
                        Opacity = 0.5;          //���������������� ���� 1.0 = 100%

                        ControlBox = false;     //��������� ��� ������ � ��������� ����
                    }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}