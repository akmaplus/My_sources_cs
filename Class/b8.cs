using System;

namespace b8
{
    //����� � ������������ Playable, IRecordable
    public class AudioFile : IPlayable, IRecordable
    {
        /*
        public void Stop()
        {
            // ��������� IPlayable 
            //Console.WriteLine("IPlayable");
        }

        public void IRecordable.Stop()
        {
            // ��������� IRecordable 
            //Console.WriteLine("IRecordable");
        }
          */
    }

    interface IPlayable
    {
        public void Stop()
        {
            // ��������� IPlayable 
        }
    }

    interface IRecordable
    {
        public void Stop()
        {
            // ��������� IPlayable 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AudioFile file = new AudioFile();

            file.Stop();                        // �������� ������ IPlayable version 
            ((IRecordable)file).Stop();         // �������� ������ IRecordabie version 
            Console.ReadKey();
        }
    }
}
