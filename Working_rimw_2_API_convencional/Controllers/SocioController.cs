using Microsoft.AspNetCore.Mvc;
using Working_rimw_2_API_convencional.Models;
using Working_rimw_2_API_convencional.Service.Implementaciones;
using Working_rimw_2_API_convencional.Service.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Working_rimw_2_API_convencional.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocioController : ControllerBase
    {

        private readonly ISocioService _socioService;

        public SocioController(ISocioService socioService)
        {
            _socioService = socioService;
        }


        // GET: api/<SocioController>
      
        [HttpGet]
        public IActionResult GetAllSocios()
        {
            var result = _socioService.GetAllSocios();
            if (result.Count > 0)
            {
                return Ok(result);
            }
            return BadRequest("La lista se encuentra vacia"); ;
        }

        // GET api/<SocioController>/5
        [HttpGet("{id}")]
        public IActionResult GetSocioById(int id)
        {
            var result = _socioService.getSocioById(id);
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest("No se encontro el Socio con id " + id);
        }

        // POST api/<SocioController>
        [HttpPost]
        public IActionResult PostSocio([FromBody] Socio socio)
        {
            if (socio == null)
            {
                return BadRequest("Los datos ingresados son incorrectos");
            }
            var result = _socioService.AddSocio(socio);
            if (result)
            {
                return Ok("Socio registrado con exito");
            }
            return BadRequest("Error al registrar el socio");


        }

        // PUT api/<SocioController>/5
        [HttpPut("{id}")]
        public IActionResult PutSocio(int id, [FromBody] Socio socio)
        {
            if (socio == null)
            {
                return BadRequest("Debe ingresardatos validos");
            }
            var result = _socioService.upDateSocio(socio);
            if (result)
            {
                return Ok("Socio actualizado con exito");
            }
            return BadRequest("Debe ingresar un ID valido para actualizar un registro");
        }

        // DELETE api/<SocioController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteSocio(int id)
        {
            var result = _socioService.RemoveSocio(id);
            if (result)
            {
                return Ok("Socio id " + id + " borrado con exito");
            }
            return BadRequest("No se encontro el socio con id " + id);
        }
    }
}
