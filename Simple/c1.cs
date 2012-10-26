using System;

class Program
{
   static void Main()    
   {
      //получение некоторой инфорации об окружении программы

    foreach( string drive in Environment.GetLogicalDrives() )
      Console.WriteLine("Drive: {0}", drive);

    Console.WriteLine("OS:                   {0}", Environment.OSVersion);

    Console.WriteLine("Number of processors: {0}", Environment.ProcessorCount);

    Console.WriteLine("Net Version:          {0}", Environment.Version);

    Console.WriteLine("MachineName:          {0}", Environment.MachineName);

    Console.WriteLine("UserName:             {0}", Environment.UserName);

    Console.WriteLine("SystemDirectory:      {0}", Environment.SystemDirectory);

   }
}

