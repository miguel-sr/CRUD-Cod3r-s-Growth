using Cod3rsGrowth.Infra.Repositorio;
using Cod3rsGrowth.Modelos;
using Microsoft.AspNetCore.Mvc;
using static Cod3rsGrowth.Servicos.Validacao;

namespace Cod3rsGrowth.Web.Controller
{
    [ApiController]
    [Route("pecas")]
    public class PecaController : ControllerBase
    {
        private readonly IRepositorio _repositorio;
        public PecaController(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IActionResult ObterTodas()
        {
            return Ok(_repositorio.ObterTodas().ToList());
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            return Ok(_repositorio.ObterPorId(id));
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Peca peca)
        {
            if (peca == null) return BadRequest();

            VerificarPecaRecebida(peca);

            peca.DataDeFabricacao = peca.DataDeFabricacao.Date;

            _repositorio.Criar(peca);

            return Created($"pecas/{peca.Id}", peca);
        }

        [HttpPatch]
        public IActionResult Atualizar([FromBody] Peca peca)
        {
            if (peca == null || peca.Id == null) return BadRequest();

            VerificarPecaRecebida(peca);

            peca.DataDeFabricacao = peca.DataDeFabricacao.Date;

            _repositorio.Atualizar(peca.Id ?? 0, peca);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _repositorio.Remover(id);
            return Ok();
        }

        private static void VerificarPecaRecebida(Peca peca)
        {
            string erros = ValidarPeca(peca);

            if (!string.IsNullOrEmpty(erros))
            {
                throw new Exception(erros);
            }
        }
    }
}
