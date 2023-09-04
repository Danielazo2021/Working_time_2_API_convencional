using Working_rimw_2_API_convencional.Models;

namespace Working_rimw_2_API_convencional.Repository
{
    public class Repository : IRepository
    {
       public  List<Socio> socios { get; set; } = new List<Socio>();

       public List<Pelicula> peliculas { get; set; } = new List<Pelicula>();


        public bool AddPelicula(Pelicula pelicula)
        {
            try
            {
                peliculas.Add(pelicula);
                return true;
            }catch (Exception ex)
            {
                return false;
            }


        }

        public bool AddSocio(Socio socio)
        {
            try
            {
                socios.Add(socio);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }



        public List<Pelicula> GetAllPeliculas()
        {
            return peliculas;
        }

        public List<Socio> GetAllSocios()
        {
            return socios;
        }




        public Pelicula getPeliculaById(int id)
        {
            var peliculaExistente = peliculas.FirstOrDefault(p => p.Id == id);

            if (peliculaExistente != null)
            {
                return peliculaExistente;
            }
            return null;

        }

        public Socio getSocioById(int id)
        {
            var socioExistente = socios.FirstOrDefault(p => p.Id == id);

            if (socioExistente != null)
            {
                return socioExistente;
            }
            return null;
        }




        public bool RemovePelicula(int id)
        {
            var peliculaExistente = peliculas.FirstOrDefault(p => p.Id == id);

            if (peliculaExistente != null)
            {
                peliculas.Remove(peliculaExistente);
                return true;
            }
            return false;
        }

        public bool RemoveSocio(int id)
        {
            var socioExistente = socios.FirstOrDefault(p => p.Id == id);

            if (socioExistente != null)
            {
                socios.Remove(socioExistente);
                return true;
            }
            return false;
        }

        public bool upDatePelicula(Pelicula pelicula)
        {
            var peliculaExistente = peliculas.FirstOrDefault(p => p.Id == pelicula.Id);

            if (peliculaExistente != null)
            {
                peliculaExistente.Duracion = pelicula.Duracion;
                peliculaExistente.Genero = pelicula.Genero;
                peliculaExistente.Description = pelicula.Description;
                return true;
            }
            return false;
        }


        public bool upDateSocio(Socio socio)
        {
            var socioExistente = socios.FirstOrDefault(p => p.Id == socio.Id);

            if (socioExistente != null)
            {
                socioExistente.Nombre = socio.Nombre;
                socioExistente.Apellido = socio.Apellido;
                socioExistente.Dirección = socio.Dirección;
                return true;
            }
            return false;
        }
    }
}
