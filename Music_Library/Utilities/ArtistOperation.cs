using System.Data.Entity;
using System.Linq;

namespace Music_Library
{
    internal class ArtistOperation : IOperation
    {
        public int Add(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Artists.Add((Artist)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public int Delete(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                var entry = musicLibraryContext.Entry((Artist)o);

                if (entry.State == EntityState.Detached)
                {
                    musicLibraryContext.Artists.Attach((Artist)o);
                }
                musicLibraryContext.Artists.Remove((Artist)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public object Get(int id)
        {
            Artist artist = null;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                artist = musicLibraryContext.Artists.Where(x => x.ArtistId == id).FirstOrDefault();
            }
            return artist;
        }

        public int Update(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Entry((Artist)o).State = EntityState.Modified;
                return musicLibraryContext.SaveChanges();
            }
        }
    }
}