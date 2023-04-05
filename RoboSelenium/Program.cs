using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RoboSelenium;
using RoboSelenium.PageObjects;
using RoboSelenium.Testes;

public class Program
{
    public static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        AoAcessarPaginaInicial aoAcessarPaginaInicial = new AoAcessarPaginaInicial();

        aoAcessarPaginaInicial.DadoSiteIniciarBusca(driver);
        aoAcessarPaginaInicial.DadoCliqueValidoRealizarBusca(driver);

        AoEfetuarBusca aoEfetuarBusca = new AoEfetuarBusca();

        aoEfetuarBusca.DadoBuscaValidaSalvarResultados(driver);

        driver.Quit();
    }
}