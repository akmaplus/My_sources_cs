using System;    //�������㥬 System, ��� ���᮫�

namespace b2
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("---");    //������ �ଠ, �᫨ ��� ������ System


           int[] lst;             //����� ��६�����
           lst = new int[3];      //���樠����஢��� ��६�����
           lst[0] = 0;
           lst[1] = 1;            //����� � ����⠬ ���ᨢ�
           lst[2] = 2;

           int[] lst2 = {1, 2, 3, 4, 5, 6, 7};    //����᪮� ᮧ����� ���ᨢ�

           string[] Hex = {"0","1","2","3", "4","5","6","7", "8","9","a","b", "c","d","e","f"};   //�������筮


           int[,]  xy  = new int[3, 3];           //2-� ���� ���ᨢ
           int[,,] xyz = new int[3, 3, 3];        //3-� ���� ���ᨢ

           int[,]  XY = { {1, 2}, {10, 20} };     //����᪨ 2-�  � 3-� ����

           int[,,]XYZ = { 
                          {//0                             X 
                              {1,2},   {3,4}     //0, 1    Z
                          },   //0     //1                 Y

                          {//1                             X
                              {11,22}, {33,44}   //0, 1    Z
                          }   //0      //1                 Y
                        };

         ///foreach(string s in Hex)       //��ॡ�� ᮤ�ন���� ��ப����� ���ᨢ�
         foreach(var s in Hex)             //⠪ ����� ��ॡ���� ��� ⨯�
            Console.WriteLine("{0}", s);     //�ଠ�� �뢮�

         Hex = null;   //����塞 ��뫪�

         object[] objs = new object[3];    //���ᨢ � ࠧ��⨯�묨 ��ꥪ⠬�
         objs[0] = 1; objs[1] = "123"; objs[2] = 2.0;     //���樠������ ����⮢ ���ᨢ� ���祭�ﬨ

        }
    }
}
