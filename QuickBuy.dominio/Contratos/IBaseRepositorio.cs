using System;
using System.Collections.Generic;

namespace QuickBuy.dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Adicionar(TEntity entidade);

        TEntity ObterPorId(int id);
        IEnumerable<TEntity> ObterTodos();

        void Remover(TEntity entidade);
        void Atuallizar(TEntity entidade);
    }
}