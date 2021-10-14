using DitaliaAPI.Business;
using DitaliaAPI.Data.VO;
using DitaliaAPI.HyperMedia.Filters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DitaliaAPI.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]

    public class FuncionarioController : ControllerBase
    {
        private IFuncionarioBusiness _funcionarioBusiness;
        public FuncionarioController(IFuncionarioBusiness funcionarioBusiness)
        {
            _funcionarioBusiness = funcionarioBusiness;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult GetAll()
        {
            return Ok(_funcionarioBusiness.FindAll());
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult FindById(int id)
        {
            var funcionario = _funcionarioBusiness.FindById(id);
            if (funcionario == null) return NotFound();
            return Ok(funcionario);

        }

        // POST api/<ValuesController>
        [HttpPost]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] FuncionarioVO funcionario)
        {
            if (funcionario == null) return BadRequest();
            return Ok(_funcionarioBusiness.Create(funcionario));
        }

        // PUT api/<ValuesController>/5
        [HttpPut]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] FuncionarioVO funcionario)
        {
            if (funcionario == null) return BadRequest();
            return Ok(_funcionarioBusiness.Update(funcionario));
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _funcionarioBusiness.Delete(id);
            return NoContent();
        }
    }
}
