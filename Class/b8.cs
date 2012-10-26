using System;

namespace b8
{
    //класс с интерфейсами Playable, IRecordable
    public class AudioFile : IPlayable, IRecordable
    {
        /*
        public void Stop()
        {
            // Интерфейс IPlayable 
            //Console.WriteLine("IPlayable");
        }

        public void IRecordable.Stop()
        {
            // Интерфейс IRecordable 
            //Console.WriteLine("IRecordable");
        }
          */
    }

    interface IPlayable
    {
        public void Stop()
        {
            // Интерфейс IPlayable 
        }
    }

    interface IRecordable
    {
        public void Stop()
        {
            // Интерфейс IPlayable 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AudioFile file = new AudioFile();

            file.Stop();                        // Вызывает версию IPlayable version 
            ((IRecordable)file).Stop();         // Вызывает версию IRecordabie version 
            Console.ReadKey();
        }
    }
}
