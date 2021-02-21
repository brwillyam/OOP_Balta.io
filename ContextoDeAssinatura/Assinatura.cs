using MaoNaMassa.ConteudoCompartilhado;
namespace MaoNaMassa.ContextoDeAssinatura
{
    public class Assinatura : Base
    {
        public Plano Plano { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsActive => EndDate <= DateTime.Now;
    }
}