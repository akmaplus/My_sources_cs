using System.Drawing;
using System.Windows.Forms;

public partial class MainWindow : Form
{

  public MainWindow(){

                        CenterToScreen();

                        AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                        AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
                        ClientSize          = new System.Drawing.Size(422, 114);
                        Name = "MainWindow";
                        Text = "Простое приложение";
                        ResumeLayout(false);
                    }
}

class App
{
        static void Main(){     Application.EnableVisualStyles();
                                Application.SetCompatibleTextRenderingDefault(false);
                                Application.Run( new MainWindow() );
                          }
}