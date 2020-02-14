using QuickBuy.dominio.Contratos;
using QuickBuy.repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyContexto QuickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }
        
        public void Adicionar(TEntity entidade)
        {
            QuickBuyContexto.Set<TEntity>().Add(entidade);
            QuickBuyContexto.SaveChanges();
        }

        public void Atuallizar(TEntity entidade) 
        {
            QuickBuyContexto.Set<TEntity>().Update(entidade);
            QuickBuyContexto.SaveChanges();

        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickBuyContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entidade)
        {
            QuickBuyContexto.Remove(entidade);
            QuickBuyContexto.SaveChanges();
        }
    }
}
