using System;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.NotificacoesDeConteudo;


namespace MaoNaMassa.ContextoDeConteudo
{
    public abstract class Base : Notificador
    {
        public Base()
        {
        Id = Guid.NewGuid();
        }
    
        public Guid Id { get; set; }
    }

}