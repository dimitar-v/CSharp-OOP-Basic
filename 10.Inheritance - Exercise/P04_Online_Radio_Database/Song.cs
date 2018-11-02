using System;
using System.Linq;

namespace P04_Online_Radio_Database
{
    class Song
    {
        private const int ARTIST_NAME_MIN_LENGTH = 3;
        private const int ARTIST_NAME_MAX_LENGTH = 20;
        private const int SONG_NAME_MIN_LENGTH = 3;
        private const int SONG_NAME_MAX_LENGTH = 30;
        private const int LENGTH_MINUTES_MIN = 0;
        private const int LENGTH_MINUTES_MAX = 14;
        private const int LENGTH_SECONDS_MIN = 0;
        private const int LENGTH_SECONDS_MAX = 59;

        private string artistName;
        private string songName;
        private string length;

        public Song(string artistName, string songName, string length)
        {
            ArtistName = artistName;
            SongName = songName;
            Length = length;
        }

        public string ArtistName
        {
            get => artistName;
            set
            {
                NameValidator(value, ARTIST_NAME_MIN_LENGTH, ARTIST_NAME_MAX_LENGTH, "Artist");
                artistName = value;
            }
        }

        public string SongName
        {
            get => songName;
            set
            {
                NameValidator(value, SONG_NAME_MIN_LENGTH, SONG_NAME_MAX_LENGTH, "Song");
                songName = value;
            }
        }

        public string Length
        {
            get => length;
            set
            {
                var time = value.Split(':');
                if (time.Length != 2 || !time[0].All(Char.IsDigit) || !time[1].All(Char.IsDigit))
                {
                    throw new ArgumentException("Invalid song length.");
                }
                TimeValidator(int.Parse(time[0]), LENGTH_MINUTES_MIN, LENGTH_MINUTES_MAX, "minutes");
                TimeValidator(int.Parse(time[1]), LENGTH_SECONDS_MIN, LENGTH_SECONDS_MAX, "seconds");
                length = value;
            }
        }

        private void TimeValidator(int time, int min, int max, string type)
        {
            if (time < min || time > max)
            {
                throw new ArgumentException($"Song {type} should be between {min} and {max}.");
            }
        }

        private void NameValidator(string name, int min, int max, string type)
        {
            if (name.Length < min || name.Length > max)
            {
                throw new ArgumentException($"{type} name should be between {min} and {max} symbols.");
            }
        }

        public int GetSongTimeInSeconds()
        {
            var time = Length.Split(':');
            return int.Parse(time[0]) * 60 + int.Parse(time[1]);
        }
    }
}
