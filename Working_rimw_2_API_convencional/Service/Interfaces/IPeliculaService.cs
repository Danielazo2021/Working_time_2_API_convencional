using Working_rimw_2_API_convencional.Models;

namespace Working_rimw_2_API_convencional.Service.Interfaces
{
    public interface IPeliculaService
    {
        bool AddPelicula(Pelicula pelicula);
        bool RemovePelicula(int id);
        Pelicula getPeliculaById(int id);
        List<Pelicula> GetAllPeliculas();
        bool upDatePelicula(Pelicula pelicula);

    }
}
