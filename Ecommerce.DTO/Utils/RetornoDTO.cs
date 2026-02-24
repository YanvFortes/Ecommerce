using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.DTO.Utils
{
    public class RetornoDTO<T>
    {
        public string Mensagem { get; set; } = string.Empty;
        public T Conteudo { get; set; }
        public RetornoDTO() { }

        public RetornoDTO(T conteudo)
        {
            Conteudo = conteudo;
            Mensagem = "ok";
        }

        public RetornoDTO(T conteudo, string mensagem)
        {
            Conteudo = conteudo;
            Mensagem = mensagem;
        }

        public static RetornoDTO<T> Fail(string erro) =>
            new RetornoDTO<T>(default!, erro);
    }
}
