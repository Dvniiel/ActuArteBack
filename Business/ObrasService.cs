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

    }
}