using QuickBuy.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.repositorio.Repositorios
{
    public class ClientRepositorio
    {
        public ClientRepositorio()
        {
            var usuarioRepositorio = new UsuarioRepositorio();
            var produto = new Produto();
            usuarioRepositorio.Adicionar(produto);
        }
    }
}
