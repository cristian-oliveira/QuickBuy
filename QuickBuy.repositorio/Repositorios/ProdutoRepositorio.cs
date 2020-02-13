using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using QuickBuy.repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyContexto _quickBuyContexto) : base(_quickBuyContexto)
        {
        }

        public void Adicionar(Pedido entidade)
        {
            throw new NotImplementedException();
        }

        public void Atuallizar(Pedido entidade)
        {
            throw new NotImplementedException();
        }

        public void Remover(Pedido entidade)
        {
            throw new NotImplementedException();
        }
    }
}
