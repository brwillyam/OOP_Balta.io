using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;
using System.Linq;
using System;

namespace MaoNaMassa.ContextoDeConteudo
{
    public class CarreiraItem : Base
    {
        
        public CarreiraItem(int ordem, string titulo, string descricao, Cursos cursos)
        {   if(cursos == null){
            AddNotificacao(new Notificacao("curso","curso invalido"));
        }
            Ordem = ordem;
            Titulo = titulo;
            Descricao = descricao;
            Cursos = cursos;
        }

        public int Ordem { get; set; }

        public string Titulo { get; set;}

        public string Descricao { get; set;}

        public Cursos Cursos { get; set;}
    }
}