using QuickBuy.dominio.Contratos;
using QuickBuy.repositorio.Contexto;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.repositorio.Repositorios
{
    public class BaseRepositorio<Entidade> : IBaseRepositorio<Entidade> where Entidade : class
    {
        protected readonly QuickBuyContexto QuickBuyContexto;
        public BaseRepositorio(QuickBuyContexto quickBuyContexto)
        {
            QuickBuyContexto = quickBuyContexto;
        }
        
        public void Adicionar(Entidade entidade)
        {
            QuickBuyContexto.Set<Entidade>().Add(entidade);
            QuickBuyContexto.SaveChanges();
        }

        public void Atuallizar(Entidade entidade) 
        {
            QuickBuyContexto.Set<Entidade>().Update(entidade);
            QuickBuyContexto.SaveChanges();

        }

        public void Dispose()
        {
            QuickBuyContexto.Dispose();
        }

        public Entidade ObterPorId(int id)
        {
            return QuickBuyContexto.Set<Entidade>().Find(id);
        }

        public IEnumerable<Entidade> ObterTodos()
        {
            return QuickBuyContexto.Set<Entidade>().ToList();
        }

        public void Remover(Entidade entidade)
        {
            QuickBuyContexto.Remove(entidade);
            QuickBuyContexto.SaveChanges();
        }
    }
}
