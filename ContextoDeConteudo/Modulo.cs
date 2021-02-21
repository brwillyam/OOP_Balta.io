using System.Collections.Generic;
using MaoNaMassa.ConteudoCompartilhado;

namespace MaoNaMassa.ContextoDeConteudo
{
    public class Modulo : Base
    {
    
        public Modulo()
        {
            Aula = new List<Aulas>();
        }
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public IList<Aulas> Aula { get; set; }
    
    }
}