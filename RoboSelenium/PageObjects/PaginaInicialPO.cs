using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RoboSelenium.PageObjects
{
    public class PaginaInicialPO
    {
        private IWebDriver driver;

        private By byBotaoBuscar;
        private By byInputBusca;
        private By byBotaoInputBusca;

        public PaginaInicialPO(IWebDriver driver)
        {
            this.driver = driver;

            //Botão Buscar
            byBotaoBuscar = By.Id("Caminho_76");

            //Input Busca
            byInputBusca = By.Name("s");

            //Botão Input Busca
            byBotaoInputBusca = By.Id("Menu_-_Busca");
        }

        public PaginaInicialPO Visitar()
        {
            driver.Navigate().GoToUrl("https://www.aec.com.br/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(3000);

            driver.FindElement(By.ClassName("adopt-c-kYgFxA")).Click();
            return this;
        }

        public PaginaInicialPO ClicarBuscar()
        {
            var linkBotaoBuscar = driver.FindElement(byBotaoBuscar);

            IAction acaoBuscar = new Actions(driver)

                //mover para o elemento do botão buscar e clicar
                .MoveToElement(linkBotaoBuscar).Click().Build();

            acaoBuscar.Perform();

            return this;
        }

        public PaginaInicialPO PreencherBusca(string busca)
        {
            var linkInputBusca = driver.FindElement(byInputBusca);

            IAction acaoPreencher = new Actions(driver)

                //mover para o elemento do input busca e clicar
                .MoveToElement(linkInputBusca).Click().Build();

            acaoPreencher.Perform();


            driver.FindElement(byInputBusca).SendKeys(busca);

            return this;
        }

        public PaginaInicialPO ClicarBuscarInformacao()
        {
            var linkBotaoInputBusca = driver.FindElement(byBotaoInputBusca);

            IAction acaoBuscarInformacao = new Actions(driver)

                //mover para o elemento do botão input buscar e clicar
                .MoveToElement(linkBotaoInputBusca).Click().Build();

            acaoBuscarInformacao.Perform();

            return this;
        }

        public void EfetuarBusca(string busca)
        {
            ClicarBuscar()
                .PreencherBusca(busca)
                .ClicarBuscarInformacao();
        }
    }
}
