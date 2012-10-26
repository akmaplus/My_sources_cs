//������������� �����, �ந������ �� ����� MarshalByRefObject, ����� � ���쭥�襬 �㤥� �ᯮ�짮������ ��� 㤠������� ����������⢨�
using System;            
using System.Runtime.Remoting;
using System.Security.Permissions;

public class SetObjectUriForMarshalTest  
{

    class TestClass : MarshalByRefObject // ����� Worker �ந������ �� ����� MarshalByRefObject
    {
    }
     //��ਡ��� ᡮન
    [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.RemotingConfiguration)] 

    public static void Main()  
    {

        TestClass obj = new TestClass();     //ᮧ���� ������� ����� TestClass

        RemotingServices.SetObjectUriForMarshal(obj, "testUri");  //������ ��� ��ꥪ� ��� ���譥�� ���蠫����

        RemotingServices.Marshal(obj);  //��������� ��� ���譥�� ���蠫���� ������� �����

        Console.WriteLine( RemotingServices.GetObjectUri(obj) );  //����� ������ ��ꥪ� ���蠫����
    }
}


//������: ����� MarshalByRefObject �।��⠢��� �㭪樮��� ��� ࠡ��� � ���蠫�����, ������������ ࠡ��� ����� 㤠�����