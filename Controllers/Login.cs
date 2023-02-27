
using DnsClient;
using fullstack.Data;
using fullstack.Model;
using Microsoft.AspNetCore.Mvc;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace fullstack.Controller
{
    // definizione globale del controller
    // risponde a http://<MIOIP>/<Route>/
    // produce JSON
    [Route("api/")]
    [ApiController]
    [Produces("application/json")]
    public class LoginController: ControllerBase
    {
        // endpoint http://<MIOIP>/<Route>/Login
        [HttpPost("Login")]
        public ActionResult<string> View(LoginData login)
        {
            LoginModel loginModel = new LoginModel();
            if (loginModel.IsSuccess(login.user, login.password))
            {
                // ritorno 200 ok
                return Ok(loginModel.u);
            }
            else
            {
                // ritorno 401 Unauthorized
                return Unauthorized(new ResponseData("wrong username or password"));
            }
        }

        // endpoint http://<MIOIP>/<Route>/Logout
        [HttpGet("Logout")]
        public ActionResult<string> View()
        {
            // ritorno 200 ok
            return Ok(new ResponseData("ok"));
        }

        // endpoint http://<MIOIP>/<Route>/User/{ID}
        [HttpGet("User/{id}")]
        public ActionResult<string> View(int id)
        {
            LoginModel loginModel = new LoginModel();
            UserData u = loginModel.GetUser(id);
            if (u != null)
            {
                // ritorno 200 ok
                return Ok(u);
            }
            else
            {
                // ritorno 401 Unauthorized
                return NotFound(new ResponseData("user not found"));
            }
        }

    }

}
