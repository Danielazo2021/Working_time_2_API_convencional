using Working_rimw_2_API_convencional.Models;

namespace Working_rimw_2_API_convencional.Service.Interfaces
{
    public interface ISocioService
    {
        bool AddSocio(Socio socio);
        bool RemoveSocio(int id);
        Socio getSocioById(int id);
        List<Socio> GetAllSocios();
        bool upDateSocio(Socio socio);
    }
}
