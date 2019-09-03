using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UberFinancas.Models;

namespace UberFinancas.Services
{
    public class UsuarioService
    {
        private readonly UberFinancasContext _context;

        public UsuarioService(UberFinancasContext context)
        {
            _context = context;
        }

        public List<Usuario> FindAll()
        {
            return _context.Usuario.ToList();
        }
    }
}
