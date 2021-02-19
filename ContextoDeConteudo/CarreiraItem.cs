using System;

namespace MaoNaMassa.ContextoDeConteudo
{
    public class CarreiraItem 
    {
        
        public CarreiraItem(int ordem, string titulo, string descricao, Cursos cursos)
        {   if(cursos == null){
            throw new System.Exception("O curso nao pode ser nulo");
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