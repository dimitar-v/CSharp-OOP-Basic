using System.Collections.Generic;
using System.Linq;

namespace P04_Online_Radio_Database
{
    class PlayList : List<Song>
    {
        public string GetTime()
        {
            int totalTime = this.Sum(s => s.GetSongTimeInSeconds());
            return $"{totalTime / 3600}h {totalTime / 60 % 60 }m {totalTime % 60 % 60}s";
        }
    }
}
