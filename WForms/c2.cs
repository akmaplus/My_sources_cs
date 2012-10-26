using System;
using System.Drawing;
using System.Text;
//using System.ComponentModel;
using System.Windows.Forms;

public partial class MainWindow : Form{

  public MainWindow(){
            CenterToScreen();

            FormClosed  += new FormClosedEventHandler(MainWindow_FormClosed);
            Load        += new EventHandler(MainWindow_Load);
            FormClosing += new FormClosingEventHandler(MainWindow_FormClosing);
            Activated   += new EventHandler(MainWindow_Activated);
            Deactivate  += new EventHandler(MainWindow_Deactivate);

            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize          = new System.Drawing.Size(422, 114);
            Name = "MainWindow";
            Text = "Простое приложение";
            ResumeLayout(false);
                     }

        void MainWindow_FormClosing(object sender, FormClosingEventArgs e){

            DialogResult dr = MessageBox.Show("Вы хотите закрыть окно приложения или нет?",
              "Событие Closing!", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No) e.Cancel = true;
            else                       e.Cancel = false;
                                                                          }

        void MainWindow_FormClosed(object sender, FormClosedEventArgs e){ }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e){  Close();  }     
        private void MainWindow_Load(object sender, System.EventArgs e){ }
        private void MainWindow_Activated(object sender, System.EventArgs e){ }
        private void MainWindow_Deactivate(object sender, System.EventArgs e){ }

}

class App{
        static void Main(){     Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run( new MainWindow() );
                          }
        }