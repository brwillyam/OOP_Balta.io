using MaoNaMassa.ConteudoCompartilhado;
using System.Collections.Generic;
using System;

namespace MaoNaMassa.ContextoDeAssinatura;

namespace MaoNaMassa.ContextoDeAssinatura;
{
    public class Aluno :Base
    {
        public Aluno()
        {
            Assinaturas = new List<Assinatura>();
        }
        public string Nome { get; set; }

        public string Email { get; set; }

        public Usuario Usuario { get; set; }

        public IList<Assinatura> Assinaturas { get; set; }

        public void CreateAssinatura(Assinatura assinatura)
        {
            if(IsPremium)
            {
                AddNotificacao(new Notificacao("Premium ", " O aluno jah tem assinatura" ));
                return;
            }
            Assinaturas.Add(assinatura);
        }

       public bool IsPremium => Assinaturas.Any(x => !x.IsInactive);
    }
}