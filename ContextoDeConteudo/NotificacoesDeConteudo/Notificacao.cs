namespace MaoNaMassa.NotificacoesDeConteudo
{
    public sealed class Notificacoes
    {
        public Notificacoes()
        {

        }
        public Notificacoes(string propriedade, string mensagem)
        {
           Propriedade = propriedade;
           Mensagem = mensagem; 
        }

        public string Propriedade { get; set; }

        public string Mensagem {get; set; }
    }

}