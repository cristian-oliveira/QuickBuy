using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using QuickBuy.repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        private QuickBuyContexto quickBuyContexto;
        public UsuarioRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
            this.quickBuyContexto = quickBuyContexto;
        }
        public Usuario Obter(string email, string senha)
        {
            return quickBuyContexto.Set<Usuario>().FirstOrDefault(user => user.Email == email && user.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return quickBuyContexto.Set<Usuario>().FirstOrDefault(user => user.Email == email);
        }
    }
}
