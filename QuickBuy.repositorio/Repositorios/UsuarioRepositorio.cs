using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using System;

namespace QuickBuy.repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>,IUsuarioRepositorio {

        public UsuarioRepositorio()
        {

        }

        internal void Adicionar(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
