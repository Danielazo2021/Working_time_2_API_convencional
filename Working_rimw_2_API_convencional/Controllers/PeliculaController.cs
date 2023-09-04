using Microsoft.AspNetCore.Mvc;
using Working_rimw_2_API_convencional.Models;
using Working_rimw_2_API_convencional.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Working_rimw_2_API_convencional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeliculaController : ControllerBase
    {
        private readonly IPeliculaService _peliculaService;

        public PeliculaController(IPeliculaService peliculaService)
        {
            _peliculaService = peliculaService;
        }



        // GET: api/<PeliculaController>
        [HttpGet]
        public IActionResult GetAllPeliculas()
        {
            var result= _peliculaService.GetAllPeliculas();
            if(result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest("La lista se encuentra vacia"); ;
        }

        // GET api/<PeliculaController>/5
        [HttpGet("{id}")]
        public IActionResult GetPeliculaById(int id)
        {
            var result = _peliculaService.getPeliculaById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No se encontro la pelicula con id "+ id); 
        }

        // POST api/<PeliculaController>
        [HttpPost]
        public IActionResult PostPelicula([FromBody] Pelicula pelicula)
        {
            if(pelicula == null)
            {
                return  BadRequest("Los datos ingresados son incorrectos");
            }
            var result = _peliculaService.AddPelicula(pelicula);
            if (result)
            {
                return Ok("Pelicula registrada con exito");
            }
            return BadRequest("Error al registrar la pelicula");


        }

        // PUT api/<PeliculaController>/5
        [HttpPut("{id}")]
        public IActionResult PutPelicula(int id, [FromBody] Pelicula pelicula)
        {
            if (pelicula == null)
            {
                return BadRequest("Debe ingresardatos validos");
            }
            var result = _peliculaService.upDatePelicula(pelicula);
            if (result)
            {
                return Ok("Pelicula actualizada con exito");
            }
            return BadRequest("Debe ingresar un ID valido para actualizar un registro");
        }

        // DELETE api/<PeliculaController>/5
        [HttpDelete("{id}")]
        public IActionResult DeletePelicula(int id)
        {
            var result = _peliculaService.RemovePelicula(id);
            if (result)
            {
                return Ok("Pelicula id "+id+ " borrada con exito");
            }
            return BadRequest("No se encontro la pelicula con id " + id);
        }
    }
}
