﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int? Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string SobreNome { get; set; }
        public virtual ICollection<Pedido> Pedidos { get; set; }
        public string Nome { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                MyString mensagemErro = new MyString("PEDIDO NÃO PODE FICAR SEM ITENS!");
                AdicionarMensagem(mensagemErro);
            }


        }
    }
}