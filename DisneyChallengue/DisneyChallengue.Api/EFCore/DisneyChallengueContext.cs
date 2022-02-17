using CLModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLData.EFCore
{
    public class DisneyChallengueContext : DbContext
    {
        public DisneyChallengueContext(DbContextOptions<DisneyChallengueContext> options)
            : base (options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
