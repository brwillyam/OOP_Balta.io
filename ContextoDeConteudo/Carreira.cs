using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using System.Linq;
using System;


namespace MaoNaMassa.ContextoDeConteudo
{
    public class Carreira : Conteudo
    {
        public Carreira(string titulo, string url)
            :base(titulo, url)
        {
            Items = new List<CarreiraItem>();
        }
        public IList<CarreiraItem> Items { get; set; }

        public int TotalCursos => Items.Count;
        // Expression Body {Expressoes de Corpo}
    }
}