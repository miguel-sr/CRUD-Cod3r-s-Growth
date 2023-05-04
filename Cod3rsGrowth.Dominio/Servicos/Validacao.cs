namespace Cod3rsGrowth.Servicos
{
    public class Validacao
    {
        public class CampoDeTexto
        {
            public CampoDeTexto(string nome, string texto, bool campoObrigatorio, bool campoNumerico) 
            {
                Nome = nome;
                Texto = texto;
                Obrigatorio = campoObrigatorio;
                Numerico = campoNumerico;
            }

            public string Nome { get; set; }
            
            public string Texto { get; set; }
            
            public bool Obrigatorio { get; set; } 
            
            public bool Numerico { get; set; }
        }

        public class CampoDeData
        {
            public CampoDeData(string nome, DateTime dataInserida, DateTime? dataMinima, DateTime? dataMaxima)
            {
                Nome = nome;
                DataInserida = dataInserida;
                DataMinima = dataMinima;
                DataMaxima = dataMaxima;
            }

            public string Nome { get; set; }

            public DateTime DataInserida { get; set; }

            public DateTime? DataMinima { get; set; }

            public DateTime? DataMaxima { get; set; }
        }

        public static string ValidarCampos(List<CampoDeTexto>? camposDeTexto, List<CampoDeData>? camposDeData) 
        {
            List<string> erros = new();

            camposDeTexto?.ForEach(campo =>
            {
                if (campo.Obrigatorio)
                {
                    if (string.IsNullOrWhiteSpace(campo.Texto))
                    {
                        erros.Add($"O campo {campo.Nome} é obrigatório. \n");
                        return;
                    }
                }

                if (campo.Numerico)
                {
                    try
                    {
                        Convert.ToInt32(campo.Texto);
                    }
                    catch
                    {
                        erros.Add($"O campo {campo.Nome} aceita apenas números. \n");
                    }
                }
            });

            camposDeData?.ForEach(campo =>
            {
                if (campo.DataInserida > campo.DataMaxima || campo.DataInserida < campo.DataMinima)
                {
                    erros.Add($"A data do campo {campo.Nome} é inválida. \n");
                }
            });

            return string.Join("", erros);
        }
    }
}
