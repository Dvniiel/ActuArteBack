using ActuArte.Models;
using ActuArte.Data;

namespace ActuArte.Business
{
    public class ObrasService : IObrasService
    {
        private readonly IObrasRepository _obraRepository;

        public ObrasService(IObrasRepository obrasRepository)
        {
            _obraRepository = obrasRepository;
        }
        public List<Obras> GetAll() => _obraRepository.GetAll();
        public Obras Get(int Id) => _obraRepository.Get(Id);
        public void Add(Obras obras) => _obraRepository.Add(obras);

        public void Delete(int Id) => _obraRepository.Delete(Id);

        public void Update(Obras obras) => _obraRepository.Update(obras);
        public void AddObra(int obraId, int sesionId, int idAsiento)
        {
            _obraRepository.AddObra(obraId, sesionId, idAsiento);


        }
    }
}