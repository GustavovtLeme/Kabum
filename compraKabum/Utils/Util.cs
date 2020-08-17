using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Processo_de_compras.Driver;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace Processo_de_compras.Utils
{
    class Util : Drivers
    {
        public IWebElement element;

        public WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));



        public bool fillElement(string xpath, string valor, int timeout)
        {

            int cont = 0;
            do
            {
                try
                {
                    element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        element.Clear();
                        element.SendKeys(valor);
                        Console.WriteLine("Elemnto preenchido com sucesso");
                        return true;
                    }
                }
                catch (Exception e)
                {
                    cont++;
                    Console.WriteLine("Exceção encontrada: " + e);
                    Console.WriteLine("Tentativa " + cont);
                }
            } while (cont < timeout);
            return false;
        }


        public void enterKey(string xpath)
        {

            element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            element.SendKeys(Keys.Enter);
        }

        public bool clickElement(string xpath, int timeout)
        {
            int cont = 0;
            do
            {
                try
                {
                    element = wait.Until(ExpectedConditions.ElementExists(By.XPath(xpath)));
                    if (!element.Displayed)
                    {
                        return false;
                    }
                    else
                    {
                        element.Click();
                        Console.WriteLine("Elemento clicado com sucesso");
                        return true;
                    }
                }
                catch (Exception e)
                {
                    cont++;
                    Console.WriteLine("Exceção encontrada: " + e);
                    Console.WriteLine("Tentativa " + cont);
                }
            } while (cont < timeout);

            return false;
        }

        public bool validarProcesso(string item, string pesquisa, int timeout)
        {
            int cont = 0;
            do
            {

                try
                {
                    if (String.Equals(item.ToUpper(), pesquisa.ToUpper()))
                    {
                        Console.WriteLine("Processo Validado");
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Processo inválido");
                        return false;
                    }
                }
                catch (Exception e)
                {
                    cont++;
                    Console.WriteLine("Exceção encontrada: " + e);
                    Console.WriteLine("Tentativa " + cont);
                }
            } while (cont < timeout);
            return false;
        }



        public string itemPesquisa(string texto)
        {

            string item = texto.Split(new string[] { "\n " }, StringSplitOptions.None).Last();

            return item;
        }

        public string armazenaTexto(string xpath, int timeout)
        {
            int cont = 0;
            do
            {
                try
                {
                    element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
                    if (!element.Displayed)
                    {
                        return null;
                    }
                    else
                    {
                        string texto = element.Text;
                        return texto;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Excessão encontrada:" + e);
                    Console.WriteLine("Tentativa " + cont);
                    cont++;
                }
            } while (cont < timeout);
            return null;
        }

    }
}
