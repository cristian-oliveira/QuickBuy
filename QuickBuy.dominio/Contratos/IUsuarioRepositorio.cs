﻿
using QuickBuy.dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.dominio.Contratos
{
    public interface IUsuarioRepositorio : IBaseRepositorio<Usuario>
    {
        Usuario Obter(string Email, string Senha);
        Usuario Obter(string Email);

    }
}