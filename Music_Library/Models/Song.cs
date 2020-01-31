namespace Music_Library
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongTitle { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public string Path { get; set; }
    }
}