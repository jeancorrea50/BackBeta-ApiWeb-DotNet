using BackBeta.AppService.Interface;
using BackBeta.Domain.Dto.User;
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
    public class UsersController : ControllerBase
    {
        private readonly IUserAppService _userService;

        public UsersController(IUserAppService userService)
        {
            _userService = userService;
        }
        //localhost:44348/api/users/
        [Authorize("Bearer")]
        [HttpGet]
        [Route("obter-todos")]
        public async Task<ActionResult> ObterTodos()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
            }

            try
            {
                return Ok(await _userService.ObterTodos());
            }

            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        //localhost:44348/api/user/{1}
        [Authorize("Bearer")]
        [HttpGet]
        [Route("obter-por-id", Name = "obterId")]
        public async Task<ActionResult> ObterPorId(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
            }

            try
            {
                return Ok(await _userService.ObterPorId(id));
            }

            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [Authorize("Bearer")]
        [HttpPost]
        [Route("criar")]
        public async Task<ActionResult> Criar([FromBody] CriarUsuarioDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _userService.Criar(user);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("obterId", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            // return 500 (caso problema)
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult> Alterar([FromBody] AtualizarUsuarioDto user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                var result = await _userService.Alterar(user);

                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest();
                }
            }
            // return 500 (caso problema)
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [Authorize("Bearer")]
        [HttpDelete]
        [Route("excluir")]
        public async Task<ActionResult> Excluir(int id)
        {
            try
            {
                var result = await _userService.Excluir(id);

                if (result == true)
                {
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            // return 500 (caso problema)
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }


    }
}


