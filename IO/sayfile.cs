                                        //�������� - ������ ���� � ����� ?????????????
class App
{
  static System.IO.FileStream fs;       //�������� ����� - (������/������) � ���� �������� ������
  static System.IO.BinaryWriter bw;     //�������� ������� - ������ ����� ���� �� �����
  static System.Text.Encoding enc;

  static void Main()
  {
     enc = System.Text.Encoding.GetEncoding(1251);

     fs = new System.IO.FileStream("log.txt", System.IO.FileMode.Create , System.IO.FileAccess.Write ); //�� ������
     bw = new System.IO.BinaryWriter(fs, enc);    //������������� �������� �������, � ��������� ������� ���������
     
     //�� ��������� ������ ���� � ��������� utf8
     SayFile("{0} - {1} - {2}", "Hello", "File", "��������");
     fs.Close();
  }
   
   static void Say(string prm, params object[] prms){  //��������� ������ �� �������
     System.Console.Write(prm, prms);               }

   static void SayFile(string prm, params object[] prms){  //��������� ������ � ����
     bw.Write(System.String.Format(prm, prms));    }
}

/* ������������ ��������� ������     
  System.IO.FileMode    .Truncate       ����� �� ���� (������� �����)
                        .OpenOrCreate   ������� ��� ������� ����� 
                        .Open           ������� ������������
                        .CreateNew      ������� ����� (���� ���� ���������� - ������������ ����������)
                        .Create         ������� (���� ���� ���������� - �� ����� �����������, ���� ���� ��� ���������� (�������) - ����������) 
                        .Append         �������� � ������� �����
  ������� � �����
  System.IO.FileAccess  .Write       ������
                        .ReadWrite   ������-������
                        .Read        ������
*/
