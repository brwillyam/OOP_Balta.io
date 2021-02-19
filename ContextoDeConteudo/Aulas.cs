using MaoNaMassa.ContextoDeConteudo.Enums;
namespace MaoNaMassa.ContextoDeConteudo
{
    public class Aulas
    {
        public int Ordem { get; set; }

        public string Titulo { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }
    }
}