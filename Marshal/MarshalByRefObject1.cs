/* показан простой способ выполнения кода в другом домене приложения. 
   В этом примере определяется класс с именем Worker, являющийся наследником класса MarshalByRefObject, 
   для которого задается метод, выводящий на экран имя домена приложения, в котором он выполняется. 

  ниже, экземпляр класса Worker создается в новом домене приложения и домене приложения, заданном по умолчанию
*/
using System;
using System.Reflection;

public class Worker : MarshalByRefObject  // класс Worker производный от класса MarshalByRefObject
{
    public void PrintDomain() //печать текущего домена приложения
    { 
        Console.WriteLine("Object is executing in AppDomain \"{0}\"",  AppDomain.CurrentDomain.FriendlyName); 
    }
}

class Example //пример-приложение
{
    public static void Main()
    {
        Worker localWorker = new Worker();    //создаем объект в домене по умолчанию

        localWorker.PrintDomain();            //печать домена приложения

        AppDomain ad = AppDomain.CreateDomain("New domain");   //создаем новый домен приложения

        //создаем экземпляр класса Worker в новом домене приложения и исполняем код метода этого экземпляра(печать домена приложения)
        Worker remoteWorker = (Worker) ad.CreateInstanceAndUnwrap(   

                              Assembly.GetExecutingAssembly().FullName,  "Worker"

                                                                 );

        remoteWorker.PrintDomain();           //печать домена приложения
    }
}

/* This code produces output similar to the following:

Object is executing in AppDomain "source.exe"
Object is executing in AppDomain "New domain"
 */


// ВЫВОДЫ - класс MarshalByRefObject предоставляет возможности по работе класса в разных доменах