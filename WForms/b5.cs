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

                        smMain.AutoSize   = false;  //��������� ����������
                        smiFile.AutoSize  = false; 
                        smiEdit.AutoSize  = false; 
                        smiHelp.AutoSize  = false;
                        smiAbout.AutoSize = false;
                        smiCopy.AutoSize  = false;
                        smiPaste.AutoSize = false;
                        smiOpen.AutoSize  = false; 
                        smiExit.AutoSize  = false;

                        smMain.SuspendLayout();  //���������� ��������� �����
                        SuspendLayout();         //���������� ��������� ����

                        smMain.Location = new Point(0, 0);

                        smMain.Size   = new Size(292, 24);  smMain.Name   = "smMain";    smMain.Text   = "������� ����";

                        smiFile.Size  = new Size(60,  20);  smiFile.Name  = "smiFile";   smiFile.Text  = "����"; 
                        smiEdit.Size  = new Size(60,  20);  smiEdit.Name  = "smiEdit";   smiEdit.Text  = "������";
                        smiHelp.Size  = new Size(60,  20);  smiHelp.Name  = "smiHelp";   smiHelp.Text  = "�������";

                        smiAbout.Size = new Size(152, 72);  smiAbout.Name = "smiAbout";  smiAbout.Text = "� ���������";
                        smiCopy.Size  = new Size(152, 22);  smiCopy.Name  = "smiCopy";   smiCopy.Text  = "����������";
                        smiPaste.Size = new Size(152, 22);  smiPaste.Name = "smiPaste";  smiPaste.Text = "��������";
                        smiOpen.Size  = new Size(152, 22);  smiOpen.Name  = "smiOpen";   smiOpen.Text  = "�������";
                        smiExit.Size  = new Size(152, 22);  smiExit.Name  = "smiExit";   smiExit.Text  = "�����";

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