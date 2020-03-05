using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.dominio.Entidades
{
    public abstract class Entidade
    {
        public virtual List<string> _mensagensValidacao { get; set; }
        protected List<string> MensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); } // Verifica se a lista mensg está vazio, e retorna uma estância, mesmo estando vazia 
        }

        protected void LimparMensagensValidacao()
        {
            MensagemValidacao.Clear();
        }

        protected void AdicionarMensagem(string mensagem)
        {
            MensagemValidacao.Add(mensagem);
        }

        public string ObterMensagemValidacao()
        {
            return string.Join(".", MensagemValidacao);
        }

        public abstract void Validate();
        public bool Validade
        {
            get { return !MensagemValidacao.Any(); } // Se não houer mensagem de validação, a classe é valida.
        }


    }
}