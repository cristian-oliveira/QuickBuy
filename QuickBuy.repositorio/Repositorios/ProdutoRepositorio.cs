using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
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

        Pedido IBaseRepositorio<Pedido>.ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Pedido> IBaseRepositorio<Pedido>.ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
