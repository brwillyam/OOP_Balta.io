using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;
using System.Linq;
using System;

namespace MaoNaMassa.NotificacoesDeConteudo
{
    public class Notificacoes
    {
        public Notificacoes()
        {

        }
        public Notificacoes(string propriedade, string mensagem)
        {
           Propriedade = propriedade;
           Mensagem = mensagem; 
        }

        public string Propriedade { get; set; }

        public string Mensagem {get; set; }
    }

}