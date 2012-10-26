using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

public class MainWindow : Form
{
  private ListView lvwPanel = new ListView();


  public MainWindow()
          : base()
                    {     Size = new Size(800, 800);   //размер формы
                          FormBorderStyle = FormBorderStyle.FixedSingle;
                          MaximizeBox = false;

      lvwPanel.Bounds = new Rectangle(new Point(10,10), new Size(300,200));

      lvwPanel.View               = View.Details;           // Set the view to show details.
      lvwPanel.LabelEdit          = true;                   // Allow the user to edit item text.
      lvwPanel.AllowColumnReorder = true;                   // Allow the user to rearrange columns.
      lvwPanel.CheckBoxes         = true;                   // Display check boxes.
      lvwPanel.FullRowSelect      = true;                   // Select the item and subitems when selection is made.
      lvwPanel.GridLines          = true;                   // Display grid lines.
      lvwPanel.Sorting            = SortOrder.Ascending;    // Sort the items in the list in ascending order.
                  
      
      ListViewItem item1 = new ListViewItem("item1",0);     // Create three items and three sets of subitems for each item.
      
      item1.Checked = true;                                 // Place a check mark next to the item.
      item1.SubItems.Add("1");
      item1.SubItems.Add("2");
      item1.SubItems.Add("3");

      ListViewItem item2 = new ListViewItem("item2",1);

      item2.SubItems.Add("4");
      item2.SubItems.Add("5");
      item2.SubItems.Add("6");

      ListViewItem item3 = new ListViewItem("item3",0);

      item3.Checked = true;                                 // Place a check mark next to the item.
      item3.SubItems.Add("7");
      item3.SubItems.Add("8");
      item3.SubItems.Add("9");

      // Create columns for the items and subitems. Width of -2 indicates auto-size.
      lvwPanel.Columns.Add("Колонка компонента",  -2, HorizontalAlignment.Left);
      lvwPanel.Columns.Add("Колонка 2",           -2, HorizontalAlignment.Left);
      lvwPanel.Columns.Add("Колонка 3",           -2, HorizontalAlignment.Left);
      lvwPanel.Columns.Add("Колонка 4",           -2, HorizontalAlignment.Center);

      //Add the items to the ListView.
      lvwPanel.Items.AddRange(new ListViewItem[]{item1,item2,item3});

      // Create two ImageList objects.
      //ImageList imageListSmall = new ImageList();
      //ImageList imageListLarge = new ImageList();

      // Initialize the ImageList objects with bitmaps.
      //imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
      //imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
      //imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage1.bmp"));
      //imageListLarge.Images.Add(Bitmap.FromFile("C:\\MyLargeImage2.bmp"));

      //Assign the ImageList objects to the ListView.
      //lvwPanel.LargeImageList = imageListLarge;
      //lvwPanel.SmallImageList = imageListSmall;
      
      this.Controls.Add(lvwPanel);  // Add the ListView to the control collection.
                          
                          lvwPanel.Dock = DockStyle.Fill;     //докировка на всю поверхность формы
                          Controls.Add(lvwPanel); 
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