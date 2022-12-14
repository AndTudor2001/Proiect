using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{
    public class ProiectContext : DbContext
    {
        public ProiectContext (DbContextOptions<ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect.Models.Tara> Tara { get; set; } = default!;


        public DbSet<Proiect.Models.Oras> Oras { get; set; }

        public DbSet<Proiect.Models.Rezervare> Rezervare { get; set; }

        public DbSet<Proiect.Models.Review> Review { get; set; }

        public DbSet<Proiect.Models.Prezentare> Prezentare { get; set; }

        public DbSet<Proiect.Models.Hotel> Hotel { get; set; }
    }
}
