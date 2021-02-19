using System.Collections.Generic;

namespace MaoNaMassa.ContextoDeConteudo
{
    public class Modulo
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