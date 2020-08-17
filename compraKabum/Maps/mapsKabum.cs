using Processo_de_compras.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processo_de_compras.Maps
{
    class mapsKabum : Util
    {

        public string searchBox = "//input[@class='sprocura']";
        public string descricaoPesquisa = "//div[text()='Smartphone Samsung Galaxy A10s']";
        public string descricaoProduto = "//div/h1[@class='titulo_det']";
        public string produtoSelecionado = "//a[text()='Smartphone Samsung Galaxy A10s, 32GB, 13MP, Tela 6.2´, Vermelho - SM-A107MZRDZTO']";
        public string btnComprar = "//div[@id='pag-detalhes']/div/div[2]/div[2]/div/div[2]/div/div";
        public string btncontinuar = "//a[text()='IR PARA O CARRINHO']";
        public string Carrinho = "//h4[text()='Smartphone Samsung Galaxy A10s, 32GB, 13MP, Tela 6.2´, Vermelho - SM-A107MZRDZTO']";


    }
}
