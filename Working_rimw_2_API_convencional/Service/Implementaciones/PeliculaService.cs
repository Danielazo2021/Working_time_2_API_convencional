using Working_rimw_2_API_convencional.Models;
using Working_rimw_2_API_convencional.Repository;
using Working_rimw_2_API_convencional.Service.Interfaces;

namespace Working_rimw_2_API_convencional.Service.Implementaciones
{
    public class PeliculaService : IPeliculaService
    {


        private readonly IRepository _repository;

        public PeliculaService(IRepository repository)
        {
            _repository = repository;
        }


        public bool AddPelicula(Pelicula pelicula)
        {
            bool respuesta = _repository.AddPelicula(pelicula);
            return respuesta;
        }

        public List<Pelicula> GetAllPeliculas()
        {
            var respuesta = _repository.GetAllPeliculas();
            return respuesta;
        }

        public Pelicula getPeliculaById(int id)
        {
            var respuesta = _repository.getPeliculaById(id);
            return respuesta;
        }

        public bool RemovePelicula(int id)
        {
            bool respuesta = _repository.RemovePelicula(id);
            return respuesta;
        }

        public bool upDatePelicula(Pelicula pelicula)
        {
            bool respuesta = _repository.upDatePelicula(pelicula);
            return respuesta;
        }

    }
}
