using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Cod3rsGrowth.Serviços
{
    public class Validacao
    {
        public class Campo
        {
            public Campo(string Nome, string Texto, bool Obrigatorio, bool Numerico) 
            {
                this.Nome = Nome;
                this.Texto = Texto;
                this.Obrigatorio = Obrigatorio;
                this.Numerico = Numerico;
            }
            public string Nome { get; set; }
            public string Texto { get; set; }
            public bool Obrigatorio { get; set; } 
            public bool Numerico { get; set; }
            
        }

        public static string CampoDeTexto(List<Campo> CamposParaValidar) 
        {
            string Erros = null;

            CamposParaValidar.ForEach(Campo =>
            {
                if (Campo.Obrigatorio)
                {
                    if (Campo.Texto.Trim().Length < 1 || Campo.Texto == null)
                    {
                        Erros = string.Join(Environment.NewLine, $"O campo {Campo.Nome} é obrigatório.", Erros);
                        return;
                    }

                }

                if (Campo.Numerico)
                {
                    try
                    {
                        Convert.ToInt32(Campo.Texto);
                    }
                    catch
                    {
                        Erros = string.Join(Environment.NewLine, $"O campo {Campo.Nome} aceita apenas números.", Erros);
                    }
                }
            });

            return Erros;
            
        }
    }
}
