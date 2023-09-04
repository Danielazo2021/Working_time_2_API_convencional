using Working_rimw_2_API_convencional.Models;

namespace Working_rimw_2_API_convencional.Repository
{
    public interface IRepository
    {
        bool AddSocio(Socio socio);
        bool RemoveSocio(int id);
        Socio getSocioById(int id);
        List<Socio> GetAllSocios();
        bool upDateSocio(Socio socio);

        // peliculas
        bool AddPelicula(Pelicula pelicula);
        bool RemovePelicula(int id);
        Pelicula getPeliculaById(int id);
        List<Pelicula> GetAllPeliculas();
        bool upDatePelicula(Pelicula pelicula);

    }
}
