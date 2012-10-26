using System.Windows.Forms;

public class MainWindow : Form
{

  public MainWindow()
          : base()
                    {
                        ClientSize          = new System.Drawing.Size(422, 114);
                        Name = "MainWindow";
                        Text = "Тест";
                        MaximizeBox = false;    //выключаем кнопки - Развернуть и 
                        MinimizeBox = false;    //Свернуть, в заголовке окна
                        ShowIcon = false;       //выключить показ значка приложения
                        HelpButton = true;      //выключить показ кнопки справки в заголовке окна
                        ShowInTaskbar = false;  //отключить видимость на панели задач
                        TopMost = true;         //отображать окно поверх всех окон
                        Opacity = 0.5;          //полупрозрачность окна 1.0 = 100%

                        ControlBox = false;     //выключить все кнопки в заголовке окна
                    }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}