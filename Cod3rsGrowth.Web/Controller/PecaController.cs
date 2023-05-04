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
        public List<Peca> ObterTodas()
        {
            return _repositorio.ObterTodas().ToList();
        }

        [HttpGet("{id}")]
        public Peca ObterPorId(int id)
        {
            return _repositorio.ObterPorId(id);
        }

        [HttpPost]
        public IActionResult Criar([FromBody] Peca novaPeca)
        {
            if (novaPeca == null) return BadRequest();

            List<Campo> CamposParaValidar = new()
            {
                new Campo("nome", novaPeca.Nome, true, false),
                new Campo("estoque", novaPeca.Estoque.ToString(), true, true)
            };

            string erros = ValidarCampoDeTexto(CamposParaValidar);

            if (erros != null)
            {
                throw new Exception($"Campos inválidos. {erros}");
            }

            var id = _repositorio.Criar(novaPeca);
            novaPeca.Id = id;

            return Created($"pecas/{id}", novaPeca);
        }

        [HttpPatch]
        public IActionResult Atualizar([FromBody] Peca pecaParaAtualizar)
        {
            if (pecaParaAtualizar == null) return BadRequest();

            List<Campo> CamposParaValidar = new()
            {
                new Campo("nome", pecaParaAtualizar.Nome, true, false),
                new Campo("estoque", pecaParaAtualizar.Estoque.ToString(), true, true)
            };

            string erros = ValidarCampoDeTexto(CamposParaValidar);

            if (erros != null)
            {
                throw new Exception($"Campos inválidos. {erros}");
            }

            _repositorio.Atualizar(pecaParaAtualizar.Id, pecaParaAtualizar);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _repositorio.Remover(id);
            return Ok();
        }
    }
}
