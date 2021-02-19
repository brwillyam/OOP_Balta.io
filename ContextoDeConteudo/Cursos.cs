using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo.Enums;

namespace MaoNaMassa.ContextoDeConteudo
{
    public class Cursos : Conteudo
    {
        public Cursos(string titulo, string url)
            :base(titulo, url)
        {
            Modulo = new List<Modulo>();
        }
        public string Tag { get; set;}
        public IList<Modulo> Modulo { get; set;}

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }

    }
}