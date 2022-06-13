using BackBeta.Domain.Dto.User;
using BackBeta.Domain.Interface.Services.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace BackBeta.Api.Controllers
{
    //http:localhost/api/User
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        //localhost:44348/api/Login/

        // [FromBody] Corpo da requesição (tudo que vai aparecer na view da api)
        [AllowAnonymous]
        [HttpPost]
        public async Task<object> Login([FromBody] LoginDto loginDto, [FromServices] ILoginService service)
        {
                if(!ModelState.IsValid)
                {
                    return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
                }
                if (loginDto == null)
                {
                    return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
                }

            try
            {
                var result = await service.ObterLogin(loginDto);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                   return NotFound();
                }
            }

            catch (ArgumentException e)
            {
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }

        }

    }
}


