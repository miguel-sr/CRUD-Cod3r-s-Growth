using System;
using System.Collections.Generic;

namespace Cod3rsGrowth.Servicos
{
    public class Validacao
    {
        public class Campo
        {
            public Campo(string nome, string texto, bool campoObrigatorio, bool campoNumerico) 
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

        public static string ValidarCampoDeTexto(List<Campo> camposParaValidar) 
        {
            string erros = null;

            camposParaValidar.ForEach(campo =>
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

            return erros;
        }
    }
}
