using Cod3rsGrowth.Infra.Repositorio;
using Cod3rsGrowth.Modelos;
using Microsoft.AspNetCore.Mvc;
using static Cod3rsGrowth.Servicos.Validacao;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            try
            {
                return Ok(_repositorio.ObterTodas().ToList());
            }
            catch (Exception erro)
            {
                return NotFound($"Erro ao obter peças. {erro}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                return Ok(_repositorio.ObterPorId(id));
            } catch (Exception erro)
            {
                return NotFound($"Erro ao obter peça com ID {id}. {erro}");
            }
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Peca peca)
        {
            try
            {
                if (peca == null) return BadRequest();

                string erros = ValidarPeca(peca);

                if (!string.IsNullOrEmpty(erros))
                {
                    return BadRequest(erros);
                }

                peca.DataDeFabricacao = peca.DataDeFabricacao.Date;

                _repositorio.Criar(peca);

                return Created($"pecas/{peca.Id}", peca);
            } catch (Exception erro)
            {
                return BadRequest($"Erro ao criar peça. {erro}");
            }
        }

        [HttpPatch]
        public IActionResult Atualizar([FromBody] Peca peca)
        {
            try
            {
                if (peca == null || peca.Id == null) return BadRequest();

                string erros = ValidarPeca(peca);

                if (!string.IsNullOrEmpty(erros))
                {
                    return BadRequest(erros);
                }

                peca.DataDeFabricacao = peca.DataDeFabricacao.Date;

                _repositorio.Atualizar(peca.Id ?? 0, peca);

                return NoContent();
            } catch (Exception erro)
            {
                return NotFound(erro.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            try
            {
                _repositorio.Remover(id);
                return NoContent();
            } catch (Exception erro)
            {
                return NotFound(erro.Message);
            }
        }
    }
}
