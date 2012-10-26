using System;
using System.Windows.Forms;
using System.Drawing;

public class MainWindow : Form
{
    private MenuStrip smMain;
    private ToolStripMenuItem smiFile;
    private ToolStripMenuItem smiOpen;
    private ToolStripMenuItem smiExit;
    private ToolStripMenuItem smiEdit;
    private ToolStripMenuItem smiCopy;
    private ToolStripMenuItem smiPaste;
    private ToolStripMenuItem smiHelp;
    private ToolStripMenuItem smiAbout;

  public MainWindow()
          : base()
                    {   Size = new System.Drawing.Size(300, 300);        //������ �����
                        FormBorderStyle = FormBorderStyle.FixedSingle;
                        MaximizeBox = false;

                        smMain   = new   MenuStrip();          //����� �������
                        smiFile  = new   ToolStripMenuItem();  //�������� �������
                        smiEdit  = new   ToolStripMenuItem();
                        smiHelp  = new   ToolStripMenuItem();
                        smiAbout = new   ToolStripMenuItem();
                        smiCopy  = new   ToolStripMenuItem();
                        smiPaste = new   ToolStripMenuItem();
                        smiOpen  = new   ToolStripMenuItem();
                        smiExit  = new   ToolStripMenuItem();

                        smMain.SuspendLayout();  //���������� ��������� �����
                        SuspendLayout();         //���������� ��������� ����

                        smMain.Location = new Point(0, 0);

                        smMain.Name   = "smMain";    smMain.Text   = "������� ����";

                        smiFile.Name  = "smiFile";   smiFile.Text  = "����"; 
                        smiEdit.Name  = "smiEdit";   smiEdit.Text  = "������";
                        smiHelp.Name  = "smiHelp";   smiHelp.Text  = "�������";

                        smiAbout.Name = "smiAbout";  smiAbout.Text = "� ���������";
                        smiCopy.Name  = "smiCopy";   smiCopy.Text  = "����������";
                        smiPaste.Name = "smiPaste";  smiPaste.Text = "��������";
                        smiOpen.Name  = "smiOpen";   smiOpen.Text  = "�������";
                        smiExit.Name  = "smiExit";   smiExit.Text  = "�����";

                        smMain.Items.AddRange(          new ToolStripItem[] { smiFile, smiEdit, smiHelp } );

                        smiFile.DropDownItems.AddRange( new ToolStripItem[] { smiOpen, smiExit  } );
                        smiEdit.DropDownItems.AddRange( new ToolStripItem[] { smiCopy, smiPaste } );
                        smiHelp.DropDownItems.AddRange( new ToolStripItem[] { smiAbout          } );

                        smiAbout.Click += new EventHandler(smMain_Click);  //��������� ����������� �������
                        smiCopy.Click  += new EventHandler(smMain_Click);
                        smiPaste.Click += new EventHandler(smMain_Click);
                        smiOpen.Click  += new EventHandler(smMain_Click);
                        smiExit.Click  += new EventHandler(smMain_Click);
                        
                        Controls.Add(this.smMain);       //�������� ������� �� �����
                        MainMenuStrip = this.smMain;     //������������� ������� ��� ��������

                        ResumeLayout(false);             //����������� ��������� �����
                        smMain.ResumeLayout(false);      //����������� ��������� ����
                        smMain.PerformLayout();          //���������� ��������� ����
                        PerformLayout();                 //���������� ��������� �����
                     }

        private void smMain_Click(object sender, EventArgs e)
        {
           ToolStripMenuItem smiSender = (ToolStripMenuItem)sender; //�������� ������-�������� �������
           Text = string.Format("{0}", smiSender.Name);             //�������� ��� ���������
        }

}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}