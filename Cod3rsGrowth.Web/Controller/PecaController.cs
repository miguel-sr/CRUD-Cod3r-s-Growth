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

            VerificarPecaRecebida(novaPeca);

            _repositorio.Criar(novaPeca);

            return Created($"pecas/{novaPeca.Id}", novaPeca);
        }

        [HttpPatch]
        public IActionResult Atualizar([FromBody] Peca pecaParaAtualizar)
        {
            if (pecaParaAtualizar == null || pecaParaAtualizar.Id == null) return BadRequest();

            VerificarPecaRecebida(pecaParaAtualizar);

            _repositorio.Atualizar(pecaParaAtualizar.Id ?? 0, pecaParaAtualizar);

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(int id)
        {
            _repositorio.Remover(id);
            return Ok();
        }

        private static void VerificarPecaRecebida(Peca pecaParaValidar)
        {
            List<CampoDeTexto> camposDeTexto = new()
            {
                new CampoDeTexto("nome", pecaParaValidar.Nome, true, false),
                new CampoDeTexto("estoque", pecaParaValidar.Estoque.ToString(), true, true)
            };

            List<CampoDeData> camposDeData = new()
            {
                new CampoDeData("data de fabricação", pecaParaValidar.DataDeFabricacao, null, DateTime.Now)
            };

            string erros = ValidarCampos(camposDeTexto, camposDeData);

            if (!string.IsNullOrEmpty(erros))
            {
                throw new Exception(erros);
            }
        }
    }
}
