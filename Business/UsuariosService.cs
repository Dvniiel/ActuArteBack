using ActuArte.Models;
using ActuArte.Data;

namespace ActuArte.Business
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuarioRepository;

        public UsuariosService (IUsuariosRepository usuariosRepository)
        {
            _usuarioRepository = usuariosRepository;
        }
        public List<Usuarios> GetAll() => _usuarioRepository.GetAll();
        public Usuarios Get(int Id) => _usuarioRepository.Get(Id);
    }
}