using Music_Library.Utilities;

namespace Music_Library
{
    public class Album
    {
        private readonly ObservableListSource<Song> songs = new ObservableListSource<Song>();

        public int AlbumId { get; set; }
        public string AlbumTitle { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
        public int Length { get; set; }

        public byte[] Cover { get; set; }

        public virtual ObservableListSource<Song> Songs
        {
            get
            {
                return songs;
            }
        }
    }
}