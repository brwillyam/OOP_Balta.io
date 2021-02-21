using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using System.Linq;
using System;


namespace MaoNaMassa.ConteudoCompartilhado
{
    public abstract class Base : Notificador
    {
        public Base()
        : base ()
        {
        Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
    }

}