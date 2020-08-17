using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Processo_de_compras.Maps;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Processo_de_compras.Steps
{
    [Binding]
    class stepsKabum : mapsKabum
    {
        string descricao;

        [Given(@"Acessar o site ""(.*)""")]
        public void DadoAcessarOSite(string p0)
        {
            abrirPagina(p0);
        }

        [Given(@"Pesquisar por ""(.*)""")]
        public void DadoPesquisarPor(string p0)
        {
            fillElement(searchBox, p0, 10);
            enterKey(searchBox);
        }

        [Given(@"Validar pesquisa por ""(.*)""")]
        public void DadoValidarPesquisaPor(string p0)
        {
            string texto = armazenaTexto(descricaoPesquisa, 10);
            string item = itemPesquisa(texto);
            validarProcesso(item, p0, 10);
        }

        [Given(@"Selecionar o aparelho da lista")]
        public void DadoSelecionarOAparelhoDaLista()
        {
            clickElement(produtoSelecionado, 10);

        }

        [Given(@"Adicionar aparelho ao carrinho de compras")]
        public void DadoAdicionarAparelhoAoCarrinhoDeCompras()
        {
            descricao = armazenaTexto(descricaoProduto, 10);
            clickElement(btnComprar, 10);
            clickElement(btncontinuar, 10);
        }

        [Then(@"Validar produto no carrinho de compras")]
        public void EntaoValidarProdutoNoCarrinhoDeCompras()
        {
            string carrinhoCompras = armazenaTexto(Carrinho, 10);
            validarProcesso(descricao, carrinhoCompras, 10);
            encerraNavegador();
        }


    }
}
