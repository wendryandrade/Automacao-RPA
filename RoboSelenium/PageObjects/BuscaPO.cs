using Microsoft.VisualBasic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using RoboSelenium.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboSelenium.PageObjects
{
    public class BuscaPO
    {
        private IWebDriver driver;

        private By byTitulo;
        private By byArea;
        private By byAutor;
        private By byDescricao;
        private By byDataPublicacao;
        private List<ResultadoBusca> ResultadosBusca;
        private By byBotaoVerMais;

        public BuscaPO(IWebDriver driver)
        {
            this.driver = driver;

            //Titulo
            byTitulo = By.ClassName("cardPost");

            //Área
            byArea = By.ClassName("hat");

            //Autor
            byAutor = By.TagName("small");

            //Descrição
            byDescricao = By.ClassName("duas-linhas");

            //Data de Publicação
            byDataPublicacao = By.TagName("small");

            //Lista Resultados da Busca
            ResultadosBusca = new List<ResultadoBusca>();

            //Ver mais
            byBotaoVerMais = By.XPath("//div[@class='ver-mais']//a");

        }

        public void SalvarResultados()
        {
            do
            {
                IList<IWebElement> Titulos = driver.FindElements(byTitulo);
                IList<IWebElement> Areas = driver.FindElements(byArea);
                IList<IWebElement> Autores = driver.FindElements(byAutor);
                IList<IWebElement> Descricoes = driver.FindElements(byDescricao);
                IList<IWebElement> DatasPublicacao = driver.FindElements(byDataPublicacao);

                string Titulo, Area, Descricao, Autor;
                DateTime DataPublicacao;

                for (int i = 0; i < Titulos.Count(); i++)
                {
                    Titulo = Titulos[i].GetAttribute("title");
                    Area = Areas[i].Text;
                    Descricao = Descricoes[i].Text;
                    Autor = Autores[i].Text.Split(' ')[2];
                    DataPublicacao = DateTime.Parse(DatasPublicacao[i].Text.Split("em ")[1]);

                    ResultadoBusca resultadoBusca = new ResultadoBusca(Titulo, Area, Autor, Descricao, DataPublicacao);
                    ResultadosBusca.Add(resultadoBusca);
                }

            } while (ClicarBotaoVerMais());

            using (var context = new ResultadoContext())
            {
                context.ResultadosBusca.AddRange(ResultadosBusca);
                context.SaveChanges();
            }
        }

        public bool ClicarBotaoVerMais()
        {
            try
            {
                var linkBotaoVerMais = driver.FindElement(byBotaoVerMais).GetAttribute("href");

                driver.Navigate().GoToUrl(linkBotaoVerMais);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
