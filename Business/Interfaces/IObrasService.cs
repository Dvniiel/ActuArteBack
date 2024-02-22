using System.Collections.Generic;
using ActuArte.Models; 

namespace ActuArte.Business
{
    public interface IObrasService
    {
        List<Obras> GetAll();
        /*
        Obras? Get(int id);
        void Update(Obras obras);
        void Add(Obras obras);
        void Delete(int id);*/
    }
}