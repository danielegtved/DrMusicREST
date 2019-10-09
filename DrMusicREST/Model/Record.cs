using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrMusicREST.Model
{
    public class Record
    {
        public Record(string title, string artist, TimeSpan duration, DateTime dateOfPublication)
        {
            Title = title;
            Artist = artist;
            Duration = duration;
            DateOfPublication = dateOfPublication;
        }

        public string Title { get; set; }
        public string Artist { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime DateOfPublication { get; set; }

    }
}
