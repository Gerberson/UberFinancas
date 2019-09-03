using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UberFinancas.Models
{
    public class UberFinancasContext : DbContext
    {
        public UberFinancasContext (DbContextOptions<UberFinancasContext> options)
            : base(options)
        {
        }

        public DbSet<UberFinancas.Models.Usuario> Usuario { get; set; }
    }
}
