using System.Data.Entity;
using System.Linq;

namespace Music_Library
{
    internal class GenreOperation : IOperation
    {
        public int Add(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Genres.Add((Genre)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public int Delete(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                var entry = musicLibraryContext.Entry((Genre)o);

                if (entry.State == EntityState.Detached)
                {
                    musicLibraryContext.Genres.Attach((Genre)o);
                }
                musicLibraryContext.Genres.Remove((Genre)o);
                return musicLibraryContext.SaveChanges();
            }
        }

        public object Get(int id)
        {
            Genre genre = null;
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                genre = musicLibraryContext.Genres.Where(x => x.GenreId == id).FirstOrDefault();
            }
            return genre;
        }

        public int Update(object o)
        {
            using (MusicLibraryContext musicLibraryContext = new MusicLibraryContext())
            {
                musicLibraryContext.Entry((Genre)o).State = EntityState.Modified;
                return musicLibraryContext.SaveChanges();
            }
        }
    }
}