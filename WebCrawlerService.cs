using HtmlAgilityPack;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace WebCrawlerDesktop
{
    public static class WebCrawlerService
    {
        public static async Task<Produto> startWebCrawlerAsync()
        {
            var html = await new HttpClient().GetStringAsync("https://api.mercadolibre.com/items/MLB1505640836/?include_attributes=all");
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var jsonElements = htmlDocument.DocumentNode.InnerHtml.Split(',');
            var SucessoRequisicao = jsonElements.Length > 0 ? true : false;    
            writeLog(SucessoRequisicao);

            var produto = new Produto
            {
                //TODO - está hardcoded, usar um select 
                Id = jsonElements[0].Substring(1, 20),
                Nome = jsonElements[2],
                Preco = jsonElements[7],
                Saldo = jsonElements[12],
                ImagemURL = "https:" + jsonElements[40].Split(':').LastOrDefault().Trim('"')
            };

            return produto;

        }

        public static void writeLog(bool success)
        {
            string mensagem = success ? " - Requisição realizada com sucesso. " : " - Erro na requisição";
            
            string path = @"c:\temp\log.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(DateTime.Now + mensagem);
                }
            }
        }
    }
}
