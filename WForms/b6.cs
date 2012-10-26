using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

public class MainWindow : Form
{
  private PictureBox pbxImage = new PictureBox();

  public MainWindow()
          : base()
                    {     Size = new Size(800, 800);   //размер формы
                          FormBorderStyle = FormBorderStyle.FixedSingle;
                          MaximizeBox = false;

                          pbxImage.SizeMode = PictureBoxSizeMode.StretchImage;  //.Zoom .Normal .CenterImage .AutoSize

                          pbxImage.Image = Image.FromFile(@"c:\work\t.png ");
                          Text = string.Format("w:{0}px h:{1}px  HR:{2}dpi VR:{3}dpi PF:{4} PD:{5} RF:{6}", 
                                                pbxImage.Image.Width, 
                                                pbxImage.Image.Height,
                                                pbxImage.Image.HorizontalResolution, 
                                                pbxImage.Image.VerticalResolution,
                                                pbxImage.Image.PixelFormat.ToString(),
                                                pbxImage.Image.PhysicalDimension.ToString(),
                                                GetMimeType(pbxImage.Image));
                          
                          pbxImage.Dock = DockStyle.Fill;     //докировка на всю поверхность формы
                          Controls.Add(pbxImage); 
                          PerformLayout();                    //произвести раскладку формы
                     }

  public static string GetMimeType(Image i)
  {
    var imgguid = i.RawFormat.Guid;
    foreach (ImageCodecInfo codec in ImageCodecInfo.GetImageDecoders()){
        if (codec.FormatID == imgguid) return codec.MimeType;          }
    return "image/unknown";
  }
}

class App
{
  static void Main(){   Application.Run( new MainWindow() );    
                    }
}