using System.Collections.Generic;
using MaoNaMassa.ContextoDeConteudo;
using MaoNaMassa.ContextoDeConteudo.Enums;
using MaoNaMassa.NotificacoesDeConteudo;
using MaoNaMassa.ConteudoCompartilhado;
using System.Linq;
using System;

namespace MaoNaMassa
{
    class Program
    {
        static void Main(string[] args)
        {
             var artigos = new List<Artigos>();
            artigos.Add(new Artigos("Artigo sobre OOP", "orientacao_a_objetos_balta"));
            artigos.Add(new Artigos("Artigo sobre C#", "CSharp"));
            artigos.Add(new Artigos("Artigo sobre .NET", "dotnet"));

            foreach (var artigo in artigos)
            {
                System.Console.WriteLine(artigo.Id);
                System.Console.WriteLine(artigo.Titulo);
                System.Console.WriteLine(artigo.Url);
            }

            var curso = new List<Cursos>();            
            var cursoOOP = new Cursos("Fundamentos OOP", "fundamentos-oop");            
            var cursoCSharp = new Cursos("Fundamentos C#", "fundamentos-csharp");            
            var cursoAspNet = new Cursos("Fundamentos ASP>NET", "fundamentos-aspnet");

            curso.Add(cursoOOP);
            curso.Add(cursoCSharp);
            curso.Add(cursoAspNet);

            
            
            var carreiras = new List<Carreira>();
            var carreiradotnet = new Carreira("Especialista .NET", "especialista-dotnet");
            var carreiraItem2 = new CarreiraItem(2, "Aprenda OOP","", cursoOOP);
            var carreiraItem = new CarreiraItem(1, "Comece por aqui","", cursoCSharp);
            var carreiraItem3 = new CarreiraItem(3, "Aprenda .NET","", cursoAspNet);
            carreiradotnet.Items.Add(carreiraItem2);
            carreiradotnet.Items.Add(carreiraItem3);
            carreiradotnet.Items.Add(carreiraItem);
            carreiras.Add(carreiradotnet);

            foreach (var carreira in carreiras){
                System.Console.WriteLine(carreira.Titulo);
                foreach (var item in carreira.Items.OrderBy(x => x.Ordem)){
                    System.Console.WriteLine($"{item.Ordem} - {item.Titulo}");
                    System.Console.WriteLine(item.Cursos.Titulo);
                    System.Console.WriteLine(item.Cursos.Level);
                     foreach (var notificacao in item.Notificacoes)
                     {
                         System.Console.WriteLine($"{notificacao.Propiedade} - {notificacao.Menssagem}");
                     }
                }
            }
            var paypalassinatura = new PaypalAssinatura();
            var aluno = new Aluno();
            aluno.CreateAssinatura(paypalassinatura);
            
        }
    }
}
