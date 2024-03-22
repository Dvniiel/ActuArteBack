using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class CredentialsRepository : ICredentialsRepository
    {
        private readonly ActuArteContext _context;

        public CredentialsRepository(ActuArteContext context)
        {
            _context = context;
        }

        public Usuarios Get(int id)
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(usuarios => usuarios.idUsuario == id);
        }
        

        public Usuarios GetByUsername(UsuariosDTO usuariosDTO) 
        {
            return _context.Usuarios.AsNoTracking().FirstOrDefault(usuarios => usuarios.nombreUsuario == usuariosDTO.nombreUsuario && usuarios.passwordUsuario == usuariosDTO.passwordUsuario);
        }
        public void Add(Usuarios usuarios)
        {
            usuarios.isAdmin = false;
            _context.Usuarios.Add(usuarios);
            _context.SaveChanges();
        }
    }
}