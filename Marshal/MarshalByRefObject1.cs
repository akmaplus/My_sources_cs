/* ������� ���⮩ ᯮᮡ �믮������ ���� � ��㣮� ������ �ਫ������. 
   � �⮬ �ਬ�� ��।������ ����� � ������ Worker, ��騩�� ��᫥������ ����� MarshalByRefObject, 
   ��� ���ண� �������� ��⮤, �뢮��騩 �� �࠭ ��� ������ �ਫ������, � ���஬ �� �믮������. 

  ����, ������� ����� Worker ᮧ������ � ����� ������ �ਫ������ � ������ �ਫ������, �������� �� 㬮�砭��
*/
using System;
using System.Reflection;

public class Worker : MarshalByRefObject  // ����� Worker �ந������ �� ����� MarshalByRefObject
{
    public void PrintDomain() //����� ⥪�饣� ������ �ਫ������
    { 
        Console.WriteLine("Object is executing in AppDomain \"{0}\"",  AppDomain.CurrentDomain.FriendlyName); 
    }
}

class Example //�ਬ��-�ਫ������
{
    public static void Main()
    {
        Worker localWorker = new Worker();    //ᮧ���� ��ꥪ� � ������ �� 㬮�砭��

        localWorker.PrintDomain();            //����� ������ �ਫ������

        AppDomain ad = AppDomain.CreateDomain("New domain");   //ᮧ���� ���� ����� �ਫ������

        //ᮧ���� ������� ����� Worker � ����� ������ �ਫ������ � �ᯮ��塞 ��� ��⮤� �⮣� �������(����� ������ �ਫ������)
        Worker remoteWorker = (Worker) ad.CreateInstanceAndUnwrap(   

                              Assembly.GetExecutingAssembly().FullName,  "Worker"

                                                                 );

        remoteWorker.PrintDomain();           //����� ������ �ਫ������
    }
}

/* This code produces output similar to the following:

Object is executing in AppDomain "source.exe"
Object is executing in AppDomain "New domain"
 */


// ������ - ����� MarshalByRefObject �।��⠢��� ���������� �� ࠡ�� ����� � ࠧ��� �������