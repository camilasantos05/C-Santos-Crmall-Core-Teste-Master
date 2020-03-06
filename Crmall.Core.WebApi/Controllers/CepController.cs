using Crmall.Core.Util;
using Microsoft.AspNetCore.Mvc;

namespace Crmall.Core.WebApi.Controllers
{
    [ApiController]
    [Route("cep")]
    public class CepController : ControllerBase
    {
        [HttpGet]
        [Route("{cep}")]
        public IActionResult BuscarCep(string cep,
                                      [FromServices] LocalizarLogradouro localizarLogradouro)
        {
            var resultado = localizarLogradouro.BuscarCep(cep);

            if (resultado == null)
              return NotFound();

            return Ok(resultado);
        }
    }
}
