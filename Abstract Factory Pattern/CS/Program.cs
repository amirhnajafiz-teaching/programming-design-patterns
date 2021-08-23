using System;

namespace ABFact
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mp3File = AbstractFactory.Audio.Build("mp3");
            var mp4File = AbstractFactory.Video.Build("mp4");
            
            Console.WriteLine(mp3File.GetInfo());
            Console.WriteLine(mp4File.GetInfo());
        }
    }
}