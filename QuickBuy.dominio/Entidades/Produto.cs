using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.dominio.Entidades
{
    public class Produto : Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }
        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
            {
                MyString mensagemErro = new MyString("Nome do produto não foi informado!");
                AdicionarMensagem(mensagemErro);
            }
            if (string.IsNullOrEmpty(Descricao)) {
                MyString mensagemErro = new MyString("Descrição do produto não foi informada!");
                AdicionarMensagem(mensagemErro);
            }
        }
    }
}