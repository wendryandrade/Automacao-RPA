using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RoboSelenium.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RoboSelenium.Testes
{
    public class AoAcessarPaginaInicial
    {
        [Fact]
        public void DadoSiteIniciarBusca(IWebDriver driver)
        {
            new PaginaInicialPO(driver)
                .Visitar();
        }

        [Fact]
        public void DadoCliqueValidoRealizarBusca(IWebDriver driver)
        {
            try
            {
                new PaginaInicialPO(driver)
                    .EfetuarBusca("Automação");
            }

            catch (Exception)
            {
                DadoSiteIniciarBusca(driver);
            }
        }
    }
}
