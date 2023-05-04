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
            string erros = null;

            camposDeTexto?.ForEach(campo =>
            {
                if (campo.Obrigatorio)
                {
                    if (string.IsNullOrWhiteSpace(campo.Texto))
                    {
                        erros = string.Join(Environment.NewLine, $"O campo {campo.Nome} é obrigatório.", erros);
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
                        erros = string.Join(Environment.NewLine, $"O campo {campo.Nome} aceita apenas números.", erros);
                    }
                }
            });

            camposDeData?.ForEach(campo =>
            {
                if (campo.DataInserida > campo.DataMaxima || campo.DataInserida < campo.DataMinima)
                {
                    erros = string.Join(Environment.NewLine, $"A data do campo {campo.Nome} é inválida.", erros);
                }
            });

            return erros;
        }
    }
}
