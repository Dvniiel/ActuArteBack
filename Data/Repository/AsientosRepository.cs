using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class AsientosRepository : IAsientosRepository
    {

         private readonly ActuArteContext _context;

        public AsientosRepository(ActuArteContext context)
        {
            _context = context;
        }

         public List<Asientos> GetAll()
        {

            return _context.Asientos.ToList();
        }

    }
}