namespace Music_Library
{
    internal enum TYPE
    {
        ALBUM,
        ARTIST,
        GENRE,
        SONG
    };

    internal class MusicLibraryOperation
    {
        public static IOperation createOperation(TYPE type)
        {
            IOperation operation = null;
            switch (type)
            {
                case TYPE.ALBUM:
                    operation = new AlbumOperation();
                    break;

                case TYPE.ARTIST:
                    operation = new ArtistOperation();
                    break;

                case TYPE.GENRE:
                    operation = new GenreOperation();
                    break;

                case TYPE.SONG:
                    operation = new SongOperation();
                    break;
            }
            return operation;
        }
    }
}