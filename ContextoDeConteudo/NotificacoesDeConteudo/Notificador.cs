using System;
using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;

namespace MaoNaMassa.NotificacoesDeConteudo
{
    public class Notificador : Conteudo
    {
        public Notificador()
        {
            
        }
        public List<Notificacao> notificacoes { get; set; }

        public void Add(Notificacao notificacao)
        {
            Notificacoes.Add(notificacao);
        }
        public void AddRange(IEnumerable<Notificacao> notificacoes)
        {
            Notificacoes.AddRange(notificacoes);
        }
    }
}