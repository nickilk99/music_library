using System.Data.Entity;
using System.Linq;

namespace Music_Library
{
    internal class AlbumOperation : IOperation
    {
        public int Add(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Albums.Add((Album)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public int Delete(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                var entry = musicLibraryContext.Entry((Album)o);

                if (entry.State == EntityState.Detached)
                {
                    musicLibraryContext.Albums.Attach((Album)o);
                }
                musicLibraryContext.Albums.Remove((Album)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public object Get(int id)
        {
            Album album = null;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                album = musicLibraryContext.Albums.Where(x => x.AlbumId == id).FirstOrDefault();
            }
            return album;
        }

        public int Update(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Entry((Album)o).State = EntityState.Modified;
                return musicLibraryContext.SaveChanges();
            }
        }
    }
}