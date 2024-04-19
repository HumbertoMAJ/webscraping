using Microsoft.AspNetCore.Mvc;
using System.Net;
using HtmlAgilityPack;
using WebScrapping.Models;
using WebScrapping.Data;
using Microsoft.EntityFrameworkCore;

namespace WebScrapping.Controllers
{

   
    public class AlimentosController : Controller
    {
        private readonly AlimentosDBContext _db;

        public AlimentosController(AlimentosDBContext db)
        {
            _db = db;
        }
       
        // Para acessar o projeto utilize: url/Alimentos

        [Route("Alimentos")]
        [HttpGet]
        public IActionResult Index()
        {
                           
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            List<Alimento> alimentos = new List<Alimento>();

            for (int a = 1; a <= 57; a++)
            {  //n todal de paginas = 57

                var web = new HtmlWeb();
                var doc = web.Load("https://www.tbca.net.br/base-dados/composicao_estatistica.php?pagina="+a);

                HtmlNodeCollection itens = doc.DocumentNode.SelectNodes("/html/body/div[1]/main/div/table/tbody/tr");

                for (int i = 1; i < itens.Count; i++) //Pegando os dados selecionados
                {
                    var item = itens[i];

                    string? codigo = item.SelectSingleNode($"/html/body/div[1]/main/div/table/tbody/tr[{i}]/td[1]/a").InnerText;

                    string? nome = item.SelectSingleNode($"/html/body/div[1]/main/div/table/tbody/tr[{i}]/td[2]/a").InnerText;

                    string? nomecf = item.SelectSingleNode($"/html/body/div[1]/main/div/table/tbody/tr[{i}]/td[3]/a").InnerText;

                    string? grupo = item.SelectSingleNode($"/html/body/div[1]/main/div/table/tbody/tr[{i}]/td[4]/a").InnerText;

                    alimentos.Add(new Alimento()//adicionando na lista de alimentos
                    {
                        Codigo = codigo,
                        Nome = nome,
                        NomeCF = nomecf,
                        Grupo = grupo

                    });


                }
            }
            // adicionando alimentos no banco e o retornando
            
           foreach (var alimento in alimentos)
               {
               if (!_db.alimentos.Any(a => a.Codigo == alimento.Codigo))
               {                   
                   _db.alimentos.Add(alimento);
               }

               }                    
               _db.SaveChanges();
            
           var alimentosDoBanco = _db.alimentos.ToList();
           return View(alimentosDoBanco);           

        }


        [Route("Alimentos/Componente/{codigo}")]
        [HttpGet]
        public IActionResult Componente(string codigo)
        {       //Recebendo o codigo e o aplicando ao fim do url para obter os componentes de determinado elemento
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            List<Composicao> composicoes = new List<Composicao>();

            var web = new HtmlWeb();
            var doc = web.Load("https://www.tbca.net.br/base-dados/int_composicao_estatistica.php?cod_produto="+ codigo);

            HtmlNodeCollection itens = doc.DocumentNode.SelectNodes("//table[@id='tabela1']/tbody/tr");

            // pegando o codigo e depois enviando para a lista para poder retornar todos os dados corretamente do banco
            string cod = codigo.Trim(); 

            composicoes.Clear();

            for (int i = 1; i < itens.Count; i++)
            {
                var item = itens[i];

                string? componente = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[1]").InnerText;
                string? unidades = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[2]").InnerText;
                string? valorp = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[3]").InnerText;
                string? desviop = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[6]").InnerText;
                string? valormin = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[4]").InnerText;
                string? valormax = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[5]").InnerText;             
                string? numeroD = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[7]").InnerText;
                string? reff = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[8]").InnerText;
                string? tipod = item.SelectSingleNode($"//table[@id='tabela1']/tbody/tr[{i}]/td[9]").InnerText;
          
                
                composicoes.Add(new Composicao()
                {
                    Componente = componente,
                    Unidades = unidades,
                    DesvioP = desviop,
                    ValorP = valorp,
                    ValorMin = valormin,
                    ValorMax = valormax,
                    NumeroD = numeroD,
                    Ref = reff,
                    TipoD = tipod,
                    Codigo = cod,
                    
            });               
            }
            //Adcionando os componentes no banco
            foreach (var comp in composicoes)
            {
                var componenteExistente = _db.composicoes.FirstOrDefault(a => a.Componente == comp.Componente && a.Codigo == comp.Codigo);
                if (componenteExistente == null)
                {
                    _db.composicoes.Add(comp);
                }
            }



            _db.SaveChanges();         
            var composicoesDoBanco = _db.composicoes.Where(c => c.Codigo == cod).ToList();
            return View(composicoesDoBanco);


           
        }
    


    }
}






















