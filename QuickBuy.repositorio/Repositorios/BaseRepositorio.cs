using QuickBuy.dominio.Contratos;
using QuickBuy.repositorio.Contexto;
using System.Collections.Generic;

namespace QuickBuy.repositorio.Repositorios
{
    public class BaseRepositorio<Entidade> : IBaseRepositorio<Entidade> where Entidade : class
    {
        private readonly QuickBuyContexto _quickBuyContexto;
        public BaseRepositorio(QuickBuyContexto _quickBuyContexto)
        {
            _quickBuyContexto = quickBuyContexto;
        }
        
        public void Adicionar(Entidade entidade)
        {
            throw new System.NotImplementedException();
        }

        public void Atuallizar(Entidade entidade) 
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public Entidade ObterPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Entidade> ObterTodos()
        {
            throw new System.NotImplementedException();
        }

        public void Remover(Entidade entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}
