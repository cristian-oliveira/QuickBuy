
namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller")]




    public class UsuarioController : Controller
    {
        [HttpGet]

        public ActionResult Get()
        {
            try
            {
                return ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }


        }
        [HttpPost]

        public ActionResult Post()
        {
            try
            {
                return ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
        [HttpPost("VerificarUsuario")]

        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if (usuario.Email == "cristian.oliveira@dtidigital.com.br" && usuario.Senha == "123")
                {
                    return ok(usuario);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}