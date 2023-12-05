using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Atrribute
{
    internal class Songs
    {
        public string title;
        public string artist;
        public int duration;

        public static int songCount = 0;
        public Songs(string aTitle, string aArtist, int aDuration)
        {
            this.title = aTitle;
            this.artist = aArtist;
            this.duration = aDuration;  
            songCount++;
        }
    }
}
