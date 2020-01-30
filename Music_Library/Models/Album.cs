using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public byte[] Cover { get; set; }
    }
}
