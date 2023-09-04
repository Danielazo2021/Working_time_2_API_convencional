using Working_rimw_2_API_convencional.Models;
using Working_rimw_2_API_convencional.Repository;
using Working_rimw_2_API_convencional.Service.Interfaces;

namespace Working_rimw_2_API_convencional.Service.Implementaciones
{
    public class SocioService : ISocioService
    {

        private readonly IRepository _repository;

        public SocioService(IRepository repository)
        {
            _repository = repository;
        }


        /* void AddSocio(Socio socio);
        void RemoveSocio(int id);
        Socio getSocioById(int id);
        List<Socio> GetAllSocios();
        void upDateSocio(Socio socio);*/



        public  bool AddSocio(Socio socio)
        {
            bool respuesta= _repository.AddSocio(socio);
            return respuesta;
        }



        public List<Socio> GetAllSocios()
        {
            var respuesta = _repository.GetAllSocios();
            return respuesta;
        }

        public Socio getSocioById(int id)
        {
            var respuesta = _repository.getSocioById(id);
            return respuesta;
        }

        public bool RemoveSocio(int id)
        {
            bool respuesta = _repository.RemoveSocio(id);
            return respuesta;
        }

        public bool upDateSocio(Socio socio)
        {
            bool respuesta = _repository.upDateSocio(socio);
            return respuesta;
        }
    }
}
