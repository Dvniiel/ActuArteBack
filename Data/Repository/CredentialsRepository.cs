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
    }
}