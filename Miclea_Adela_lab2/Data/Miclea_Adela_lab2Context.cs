using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Miclea_Adela_lab2.Models;

namespace Miclea_Adela_lab2.Data
{
    public class Miclea_Adela_lab2Context : DbContext
    {
        public Miclea_Adela_lab2Context (DbContextOptions<Miclea_Adela_lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Miclea_Adela_lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Miclea_Adela_lab2.Models.Publisher> Publisher { get; set; }
    }
}
