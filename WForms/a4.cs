using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {   //� ���������� �������� �� ���� ������� ����� this - ��������������, ��� ���� ������ ����� ������������

                        //this.ClientSize          = new System.Drawing.Size(422, 114);
                        this.Size = new System.Drawing.Size(300, 300);  //������ ������ �����

                        this.Name = "MainWindow";
                        this.Text = "����";
                        this.MaximizeBox = false; 
                                                                            //������ ������ �����:
                        this.FormBorderStyle = FormBorderStyle.FixedSingle; //SizableToolWindow Sizable None FixedToolWindow FixedDialog Fixed3D

                     }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}