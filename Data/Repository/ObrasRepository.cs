using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ActuArte.Models;

namespace ActuArte.Data
{
    public class ObrasRepository : IObrasRepository
    {
        private readonly ActuArteContext _context;

        public ObrasRepository(ActuArteContext context)
        {
            _context = context;
        }

        public List<Obras> GetAll()
        {

            return _context.Obras.ToList();
        }

        public Obras Get(int id)
        {
            return _context.Obras.AsNoTracking().FirstOrDefault(obras => obras.idObra == id);
        }

        public void Add(Obras obras)
        {
            _context.Obras.Add(obras);
            _context.SaveChanges();
        }

        public void Update(Obras obras)
        {

            _context.Entry(obras).State = EntityState.Modified;
            _context.SaveChanges();

        }


        public void Delete(int id)
        {
            var obras = _context.Obras.FirstOrDefault(obras => obras.idObra == id);
            _context.Obras.Remove(obras);
            _context.SaveChanges();
        }

    }
}