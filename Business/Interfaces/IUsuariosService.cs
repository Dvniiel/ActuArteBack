using System.Collections.Generic;
using ActuArte.Models; 
using System.Threading.Tasks;

namespace ActuArte.Business
{
    public interface IUsuariosService
    {
        List<Usuarios> GetAll();
        
        Usuarios? Get(int Id);
    }
}