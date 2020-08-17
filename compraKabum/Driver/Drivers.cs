using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processo_de_compras.Driver
{
    class Drivers
    {

        public static IWebDriver driver = iniciaNavegador();


        public static IWebDriver iniciaNavegador()
        {
            ChromeOptions option = new ChromeOptions();
            var path = "C:\\Users\\Windslasher\\source\\repos\\compraKabum\\compraKabum\\Driver"; //Caminho deve ser alterado para iniciar corretamente em outro computador pois local do chromedriver muda de computador para computador
            option.AddArguments(/*"-incognito",*/ "-start-maximized");
            driver = new ChromeDriver(@path, option);
            return driver;
        }

        public void encerraNavegador()
        {
            driver.Close();
            driver.Quit();
        }

        public void abrirPagina(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

    }
}
