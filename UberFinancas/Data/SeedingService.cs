using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberFinancas.Models;

namespace UberFinancas.Data
{
    public class SeedingService
    {
        private readonly UberFinancasContext _context;

        public SeedingService(UberFinancasContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Usuario.Any())
            {
                return; // BANCO DE DADOS JA FOI POPULADO
            }

            Usuario u1 = new Usuario(1, "Flor", 23, 2.00, DateTime.Now);
            Usuario u2 = new Usuario(2, "Pedro", 25, 3.00, DateTime.Now);
            Usuario u3 = new Usuario(3, "Luiz", 45, 4.00, DateTime.Now);
            Usuario u4 = new Usuario(4, "Carlos", 53, 5.00, DateTime.Now);

            _context.Usuario.AddRange(u1, u2, u3, u4);

            _context.SaveChanges();
        }
    }
}
