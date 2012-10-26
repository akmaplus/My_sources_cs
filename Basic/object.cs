using System;
// ������ - ����� System.Object �।��⠢��� �᭮�� 蠡��� �� ��⠫��� ����ᮢ �㭪樮������� � CLR
// �᭮���� ���⠢�� ����� - ��⮤� �� ࠡ�� � 蠡����� ����⮢���, �஢�ઠ �� ࠢ���⢮ ��뫮�, 
// ࠢ���⢮ ����७���� ᮤ�ঠ���, ��� ���筮�� �।�⠢����� ��ꥪ� � ��㣨�. �� �� ��⮤� ��८�।��塞� � ��⮬���!

class Point // ����� Point �ந������ �� System.Object
{
    public int x, y;   //�㡫��� ���� �����

    //���������
    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }

    //��८�।������ ��⮤� - �ࠢ����� ����७��� ����� ��ꥪ⮢
    public override bool Equals(object obj) 
    {
        if ( obj.GetType() != this.GetType() ) return false;  // ������� ���� - �᫨ ��뫪� �� ��ꥪ� �⫨筮�� �� ��襣� ⨯�
        
        Point other = (Point) obj;  //�८�ࠧ㥬 � ��襬� ⨯�

        return (this.x == other.x) && (this.y == other.y);  // ������� ��⨭� - �᫨ �㡫��� ���� ��ꥪ⮢ ࠢ�������
    }
    
    //��८�।������ ��⮤�
    public override int GetHashCode() // ����� ��� ��� ��ꥪ�
    {
        return x ^ y;
    }

    //��८�।������ ��⮤�
    public override String ToString()  // ����� � ⥪�⮢��(ᨬ���쭮�) �।�⠢�����
    {
        return String.Format("({0}, {1})", x, y);
    }

    
    public Point Copy()   // ������� ����� ��ꥪ� - ��⥬ ���⮣� �����஢���� 童��� ��ꥪ�
    {
        return (Point) this.MemberwiseClone();
    }
}



public sealed class App 
{
    static void Main() 
    {
        Point p1 = new Point(1,2);      // ᮧ���� ��ꥪ� Point

        Point p2 = p1.Copy();           // ᮧ���� ����� ��ࢮ�� ��ꥪ� 
       
        Point p3 = p1;                  // ᮧ���� ��뫪� �� ���� ��ꥪ�

        
        Say("{0}\n", Object.ReferenceEquals(p1, p2));   // �᫨ ��뫪� ��ࠢ��
        
        Say("{0}\n", Object.Equals(p1, p2));            // �᫨ ��ꥪ�� ࠢ��
        
        Say("{0}\n", Object.ReferenceEquals(p1, p3));   // �᫨ ��뫪� ࠢ��
        
        Say("p1's value is: {0}\n", p1.ToString());     // ����� ��ꥪ� � ���筮� ����: (1, 2)
    }

   static void Say(string prm, params object[] prms){  //�ଠ⭠� ����� �� ���᮫�
     System.Console.Write(prm, prms);               }
}

// This code example produces the following output:
//
// False
// True
// True
// p1's value is: (1, 2)
//