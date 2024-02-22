using System.Dynamic;
using ActuArte.Models;

namespace ActuArte.Data
{
    public interface IObrasRepository
    {
        List<Obras> GetAll();

        Obras Get(int Id);

        void Update(Obras obras);
    }
}
