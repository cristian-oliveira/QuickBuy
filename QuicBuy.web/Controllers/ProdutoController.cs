using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using QuickBuy.repositorio.Repositorios;
using System;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace QuicBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
           // _produtoRepositorio = new ProdutoRepositorio(new QuickBuy.repositorio.Contexto.QuickBuyContexto());
            _produtoRepositorio = produtoRepositorio;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_produtoRepositorio.ObterTodos()); // Se for ok ele retorna os  produtos cadastrados na base de dados 
                //if (condicao == false)
                //    return BadRequest("");
            }catch (Exception ex){
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody]Produto produto)// transforma a informacao vinda de json em objeto conhecido
        {
            try
            {
                //produto.Nome = "";
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto); // retorna se conseguiu criar produto
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
