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
        public DbSet<Genre> Genres { get; set; }
    }
}
