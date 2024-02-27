using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly ActuArteContext _context;

        public UsuariosRepository(ActuArteContext context)
        {
            _context = context;
        }

        public List<Usuarios> GetAll()
        {

            return _context.Usuarios.ToList();

        }
         public Usuarios Get(int Id)
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(usuarios => usuarios.idUsuario == Id);
        }
    }
}