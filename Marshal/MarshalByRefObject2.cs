//демонстрируется класс, производный от класса MarshalByRefObject, который в дальнейшем будет использоваться для удаленного взаимодействия
using System;            
using System.Runtime.Remoting;
using System.Security.Permissions;

public class SetObjectUriForMarshalTest  
{

    class TestClass : MarshalByRefObject // класс Worker производный от класса MarshalByRefObject
    {
    }
     //атрибуты сборки
    [SecurityPermission(SecurityAction.Demand, Flags=SecurityPermissionFlag.RemotingConfiguration)] 

    public static void Main()  
    {

        TestClass obj = new TestClass();     //создаем экземпляр класса TestClass

        RemotingServices.SetObjectUriForMarshal(obj, "testUri");  //задать имя объекта для внешнего маршалинга

        RemotingServices.Marshal(obj);  //подключить для внешнего маршалинга экземпляр класса

        Console.WriteLine( RemotingServices.GetObjectUri(obj) );  //печать локатора объекта маршалинга
    }
}


//ВЫВОДЫ: класс MarshalByRefObject предоставляет функционал для работы с маршалингом, возможностью работы класса удаленно