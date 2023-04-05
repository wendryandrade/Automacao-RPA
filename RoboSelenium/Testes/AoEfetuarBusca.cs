using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboSelenium.PageObjects;
using Xunit;

namespace RoboSelenium.Testes
{
    public class AoEfetuarBusca
    {
        [Fact]
        public void DadoBuscaValidaSalvarResultados(IWebDriver driver)
        {
            new BuscaPO(driver)
                .SalvarResultados();
        }
    }
}
