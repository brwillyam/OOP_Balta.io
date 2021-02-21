using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using System.Linq;
using System;

namespace MaoNaMassa.ContextoDeConteudo
{
    
    public class Artigos : Conteudo
    {
        public Artigos(string titulo, string url)
            :base(titulo, url)
        {

        }
    }
}