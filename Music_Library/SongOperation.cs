using System.Data.Entity;
using System.Linq;

namespace Music_Library
{
    internal class SongOperation : IOperation
    {
        public int Add(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Songs.Add((Song)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public int Delete(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                var entry = musicLibraryContext.Entry((Song)o);

                if (entry.State == EntityState.Detached)
                {
                    musicLibraryContext.Songs.Attach((Song)o);
                }
                musicLibraryContext.Songs.Remove((Song)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public object Get(int id)
        {
            Song song = null;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                song = musicLibraryContext.Songs.Where(x => x.SongId == id).FirstOrDefault();
            }
            return song;
        }

        public int Update(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Entry((Song)o).State = EntityState.Modified;
                return musicLibraryContext.SaveChanges();
            }
        }
    }
}