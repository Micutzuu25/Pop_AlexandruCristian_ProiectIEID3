using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pop_AlexandruCristian_ProiectIEID3.Models;

namespace Pop_AlexandruCristian_ProiectIEID3.Data
{
    public class Pop_AlexandruCristian_ProiectIEID3Context : DbContext
    {
        public Pop_AlexandruCristian_ProiectIEID3Context (DbContextOptions<Pop_AlexandruCristian_ProiectIEID3Context> options)
            : base(options)
        {
        }

        public DbSet<Pop_AlexandruCristian_ProiectIEID3.Models.Automobil> Automobil { get; set; } = default!;

        public DbSet<Pop_AlexandruCristian_ProiectIEID3.Models.Vanzator> Vanzator { get; set; }

        public DbSet<Pop_AlexandruCristian_ProiectIEID3.Models.Category> Category { get; set; }
    }
}
