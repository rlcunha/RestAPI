using DitaliaAPI.Business;
using DitaliaAPI.Data.VO;
using DitaliaAPI.HyperMedia.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DitaliaAPI.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]

    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private IUsuarioBusiness _usuarioBusiness;
        public UsuarioController(IUsuarioBusiness usuarioBusiness, ILogger<UsuarioController> logger)
        {
            _logger = logger;
            _usuarioBusiness = usuarioBusiness;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {
            return Ok(_usuarioBusiness.FindAll());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindById(int id)
        {
            var usuario = _usuarioBusiness.FindById(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);

        }

        // POST api/<ValuesController>
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] UsuarioVO usuario)
        {
            if (usuario == null) return BadRequest();
            return Ok(_usuarioBusiness.Create(usuario));
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] UsuarioVO usuario)
        {
            if (usuario == null) return BadRequest();
            return Ok(_usuarioBusiness.Update(usuario));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioBusiness.Delete(id);
            return NoContent();
        }
    }
}
