using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using QuickBuy.dominio.Contratos;
using QuickBuy.dominio.Entidades;
using QuickBuy.repositorio.Repositorios;
using System;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace QuicBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private IHttpContextAccessor _httpContextAcessor;
        private IHostingEnvironment _hostingEnviroment;
        public ProdutoController(IProdutoRepositorio produtoRepositorio, IHttpContextAccessor httpContextAcessor, IHostingEnvironment hostingEnviroment)
        {
            _httpContextAcessor = httpContextAcessor;
            _produtoRepositorio = produtoRepositorio;
            _hostingEnviroment = hostingEnviroment;
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
                _produtoRepositorio.Adicionar(produto);
                return Created("api/produto", produto); // retorna se conseguiu criar produto
            
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
