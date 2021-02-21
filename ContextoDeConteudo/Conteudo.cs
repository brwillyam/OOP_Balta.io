using System;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;


namespace MaoNaMassa.ContextoDeConteudo
{
    public class Conteudo : Base
    {
        public Conteudo(string titulo, string url)
        {
            Titulo = titulo;
            Url = url;
        }

        public string Titulo { get; set; }

        public string Url { get; set; }
    }
}