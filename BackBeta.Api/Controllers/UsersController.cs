using BackBeta.Domain.Entities;
using BackBeta.Domain.Interfaces.Services.User;
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
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        //localhost:44348/api/users/
        [HttpGet]
        [Route("obter-todos")]
        public async Task<ActionResult> GetAll()
        {
           
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
            }

            try
            {
                return Ok(await _userService.GetAll());
            }

            catch (ArgumentException e)
            {
                return StatusCode ((int) HttpStatusCode.InternalServerError, e.Message);
            }

        }

        //localhost:44348/api/user/{1}
        [HttpGet]
        [Route("obter-por-id", Name = "getId")]
        public async Task<ActionResult> GetPorId(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
            }

            try
            {
                return Ok(await _userService.Get(id));
            }

            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [HttpPost]
        [Route("criar")]
        public async Task<ActionResult> Criar([FromBody]UserEntity user)
        {
            try
            {
                var result = await _userService.Post(user);

                if(result != null)
                {
                     return Created (new Uri(Url.Link ("getId", new {id = result.Id})), result);
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
        [HttpPut]
        [Route("alterar")]
        public async Task<ActionResult> Alterar([FromBody] UserEntity user)
        {
            try
            {
                var result = await _userService.Put(user);

                if (result != null)
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

        [HttpDelete]
        [Route("excluir")]
        public async Task<ActionResult> Excluir(int id)
        {
            try
            {
                var result = await _userService.Delete(id);

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


