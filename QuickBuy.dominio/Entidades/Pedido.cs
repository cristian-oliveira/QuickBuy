using QuickBuy.dominio.Entidades.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<ItemPedido> ItensPedidos { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagementoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedidos.Any())
            {
                AdicionarMensagem("PEDIDO NÃO PODE FICAR SEM ITENS!");

                if (string.IsNullOrEmpty(CEP))
                {
                    AdicionarMensagem("PEDIDO NÃO PODE FICAR SEM ITENS!");
                }
            }

        }
    }
}
