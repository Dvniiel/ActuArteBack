using ActuArte.Models;
using ActuArte.Data;

namespace ActuArte.Business
{
    public class CredentialsService : ICredentialsService
    {
        private readonly ICredentialsRepository _credentialsRepository;

        public CredentialsService(ICredentialsRepository credentialsRepository)
        {
            _credentialsRepository = credentialsRepository;
        }

        public Usuarios Get(int Id) => _credentialsRepository.Get(Id);
        

        public Usuarios Authenticate(UsuariosDTO usuariosDTO)
        {
            
            var usuario = _credentialsRepository.GetByUsername(usuariosDTO);

            
            if (usuario == null)
            {
                return null;
            }

            return usuario; 
        }

        public void Add(Usuarios usuarios) => _credentialsRepository.Add(usuarios);

    }
}