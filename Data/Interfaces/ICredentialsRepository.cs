using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface ICredentialsRepository
    {
        Usuarios Get(int Id);

        Usuarios GetByUsername(UsuariosDTO usuariosDTO);

        void Add(Usuarios usuarios);
    }
}