using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using apiLogin.Security;
using Microsoft.AspNetCore.Cors;

namespace apiLogin.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
       
        // [EnableCors("AllowSpecificOrigin")]
      //  [DisableCors]
        [AllowAnonymous]
        [HttpPost]
        public object Post(
            [FromBody]User usuario,
            [FromServices]AccessManager accessManager)
        {
            if (accessManager.ValidateCredentials(usuario))
            {
                return accessManager.GenerateToken(usuario);
            }
            else
            {
                return new
                {
                    Authenticated = false,
                    Message = "Falha ao autenticar"
                };
            }
        }
    }
}