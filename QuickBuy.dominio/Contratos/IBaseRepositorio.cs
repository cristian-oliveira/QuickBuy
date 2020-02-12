using System;
using System.Collections.Generic;

namespace QuickBuy.dominio.Contratos
{
    public interface IBaseRepositorio<Entidade> : IDisposable where Entidade : class
    {
        void Adicionar(Entidade entidade);

        Entidade ObterPorId(int id);
        IEnumerable<Entidade> ObterTodos();

        void Remover(Entidade entidade);
        void Atuallizar(Entidade entidade);
    }
}