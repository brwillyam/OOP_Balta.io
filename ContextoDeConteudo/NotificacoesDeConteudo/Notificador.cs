using System;
using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.NotificacoesDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;
using System.Linq;


namespace MaoNaMassa.NotificacoesDeConteudo
{
    public abstract class Notificador 
    {
        
        public List<Notificacao> Notificacoes { get; set; }

        public Notificador()
        {
           Notificacoes = new List<Notificacao>(); 
        }
        

        public void AddNotificacao(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AddNotificacoes(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
        public bool EEnvalido => Notificacoes.Any();
    }
}