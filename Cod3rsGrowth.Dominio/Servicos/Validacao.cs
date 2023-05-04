using Cod3rsGrowth.Modelos;
using System.Text.RegularExpressions;

namespace Cod3rsGrowth.Servicos
{
    public class Validacao
    {
        public static string ValidarPeca(Peca peca)
        {
            int quantidadeMinimaEstoque = default;
            List<string> erros = new();

            if (string.IsNullOrWhiteSpace(peca.Nome)) erros.Add("O campo nome é obrigatório.");
               
            if (!Regex.Match(peca.Nome, @"^\w|\s([p{L}])$").Success) erros.Add("O campo nome não aceita caracteres especiais.");
               
            if (string.IsNullOrWhiteSpace(peca.Estoque)) erros.Add("O campo estoque é obrigatório.");

            try
            {
                var quantidadeEstoque = Convert.ToInt32(peca.Estoque);

                if (quantidadeEstoque <= quantidadeMinimaEstoque)
                {
                    erros.Add($"A quantidade mínima de peças para adicionar deve ser maior que {quantidadeMinimaEstoque}");
                }
            }
            catch 
            {
                erros.Add("O campo estoque aceita apenas números.");
            }

            if (peca.DataDeFabricacao > DateTime.Now) erros.Add($"A data máxima aceita é {DateTime.Now.Date.ToShortDateString()}.");

            var dataMinimaAceita = DateTime.Parse("1754-01-01T12:00:20.031Z");

            if (peca.DataDeFabricacao < dataMinimaAceita) erros.Add($"A data mínima aceita é {dataMinimaAceita.Date.ToShortDateString()}.");

            return string.Join(Environment.NewLine, erros);
        }
    }
}
