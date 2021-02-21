using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;
using System.Linq;
using System;
namespace MaoNaMassa.ContextoDeConteudo
{
    public class Aulas : Base
    
    {
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}