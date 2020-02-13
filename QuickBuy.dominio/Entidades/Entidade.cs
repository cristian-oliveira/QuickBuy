﻿using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.dominio.Entidades
{
    public abstract class Entidade
    {
        public List<MyString> _mensagensValidacao { get; set; }
        protected List<MyString> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<MyString>()); } // Verifica se a lista mensg está vazio, e retorna uma estância, mesmo estando vazia 
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(MyString mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool Validade
        {
            get { return !MensagemValidacao.Any(); } // Se não houer mensagem de validação, a classe é valida.
        }


    }
}