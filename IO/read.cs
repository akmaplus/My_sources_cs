class App
{
 static void Main()
 {
     string fn = "test";

     using ( System.IO.FileStream   fs = new System.IO.FileStream(fn, System.IO.FileMode.Open, System.IO.FileAccess.Read) )
     // using ( System.IO.BinaryReader br = new System.IO.BinaryReader(fs))
     { 
           Say("Filesize:{0} bytes\nPos:{1}\n", fs.Length, fs.Position);

            byte [] bt = new byte[100];

            //while(true)
            if( bt[0] != fs.ReadByte() )
              break; //Say("EOF");
            else 
              Say("{0}\n", bt[0]); 

            //if ( bt[0] != fs.ReadByte() )
            //if (b != fs.ReadByte())

            //Say("{0}\n", bt);


      //SayFile(bw, "{0} - {1}\n", "�ਢ��", "䠩�");

     }

 }
   static void Say(string prm, params object[] prms){  //�ଠ⭠� �����
     System.Console.Write(prm, prms);               }
}

/* ����䨪���� 䠩������ ०���     
  System.IO.FileMode    .Truncate       ���� �� ��� (���⮣� 䠩��)
                        .OpenOrCreate   ������ ��� ᮧ���� ���� 
                        .Open           ������ �������騩
                        .CreateNew      ᮧ���� ���� (�᫨ 䠩� ������� - ���������� �᪫�祭��)
                        .Create         ᮧ���� (�᫨ 䠩� ������� - �� �㤥� ��१���ᠭ, �᫨ 䠩� 㦥 ������� (�����) - �᪫�祭��) 
                        .Append         �������� � ����� 䠩��
  ����㯠 � 䠩��
  System.IO.FileAccess  .Write       ������
                        .ReadWrite   ������-�⥭��
                        .Read        �⥭��
*/
