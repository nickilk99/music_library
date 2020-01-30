using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Library
{
    class MusicLibraryContext : DbContext
    {
        public MusicLibraryContext() : base("name = Music_Library_ConnectionString")
        {

        }

		public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }
		public DbSet<Artist> Artists { get; set; }
    }
}
