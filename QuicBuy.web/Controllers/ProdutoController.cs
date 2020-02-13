using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using QuickBuy.dominio.Contratos;
using QuickBuy.repositorio.Repositorios;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace QuicBuy.web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            //_produtoRepositorio = new ProdutoRepositorio(new QuickBuy.repositorio.Contexto.QuickBuyContexto()); 
           _produtoRepositorio = produtoRepositorio;


        }

    }
}
