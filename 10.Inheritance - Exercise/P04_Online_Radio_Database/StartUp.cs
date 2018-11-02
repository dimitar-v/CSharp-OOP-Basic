using System;

namespace P04_Online_Radio_Database
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            PlayList songs = new PlayList();

            for (int i = 0; i < num; i++)
            {
                var songInfo = Console.ReadLine().Split(';');
                try
                {
                    if (songInfo.Length != 3)
                    {
                        throw new ArgumentException("Invalid song.");
                    }

                    songs.Add(new Song(songInfo[0], songInfo[1], songInfo[2]));
                    Console.WriteLine("Song added.");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            Console.WriteLine($"Songs added: {songs.Count}{Environment.NewLine}" 
                            + $"Playlist length: {songs.GetTime()}");
        }
    }
}
