class App
{
  static void Main()
  {
     string[] s = {"asd", "z", "ASD", "123", "Z", "__1"};  //ᮡ�⢥��� ��室�� ���ᨢ

     Say("\nRank:{0} Length:{1}\n", s.Rank, s.Length );    //����� ����७�� � ������⢮ ����⮢ � ���ᨢ�

     Say(ref s);                  //����� ��室���� ���ᨢ�

     System.Array.Sort(s);        //���஢�� ���ᨢ�

     Say(ref s);                  //����� �����஢������ ���ᨢ�

     System.Array.Reverse(s);     //ॢ��� ���ᨢ�

     Say(ref s);                  //����� ��ॢ���஢������ ���ᨢ�

     string[] s2 = new string[s.Length+3];   //ᮧ���� ���� ���ᨢ ��ப, �� ����� ����� ���. �� 3

     s.CopyTo(s2,3);              //����஢��� �� ������ ���. ���ᨢ� s, � 楫���� ���ᨢ 1), ��稭�� � ����樨 2) � 楫����
     Say(ref s2);                 //����� 楫����� ���ᨢ�

     System.Array.Clear(s,0,5);   //���⪠ ����⮢ ᯨ᪠ 1) �� ���祭��, ��稭�� 2), � ���-�� 3)
                                  //0 - ��� �ᥫ, null - ��ꥪ⮢, false - �����᪨�

     Say(ref s);                  //����� ��饭����  ���ᨢ�

     string[] da;     //ࠧ��୮��� ���ᨢ� �� 㪠���� - �������᪨� ���ᨢ, ࠧ�� ���. �� �६� ����権 � ���
   

  }

  static void Say(ref string[] prm) { //����� ����⮢ ��ப����� ���ᨢ�
                                      foreach(string s in prm) 
                                      Say("{0}\t", s);          //ࠧ����� ⠡��樥�
                                      Say("\n");  
                                    }

  static void Say(string prm, params object[] prms)  //�-�� ���� �� ���᮫�, � �ଠ�� �뢮���     
                                    {
                                      System.Console.Write(prm, prms);
                                    }

}
