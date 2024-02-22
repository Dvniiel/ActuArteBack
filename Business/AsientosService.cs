using ActuArte.Models;
using ActuArte.Data;

namespace ActuArte.Business
{
    public class AsientosService
    {
        private readonly ActuArteContext _context;

        public AsientosService(ActuArteContext context)
        {
            _context = context;
        }

    }
}