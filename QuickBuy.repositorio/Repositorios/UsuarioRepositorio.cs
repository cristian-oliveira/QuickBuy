using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using QuickBuy.repositorio.Contexto;
using System;

namespace QuickBuy.repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
        }

        public UsuarioRepositorio(QuickBuyContexto _quickBuyContexto) : base(_quickBuyContexto)
        {
        }

        internal void Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
