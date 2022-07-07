using BackBeta.AppService.Interface;
using BackBeta.AppService.ViewModel.Selecao;
using BackBeta.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;

namespace BackBeta.Api.Controllers
{
        //http:localhost/api/User
        [Route("api/[controller]")]
        [ApiController]
        [Authorize]
        public class ProdutoController : ControllerBase
        {
            private readonly IProdutoAppService _produtoAppService;

            public ProdutoController(IProdutoAppService produtoAppService)
            {
                _produtoAppService = produtoAppService;
            }

            [AllowAnonymous]
            [HttpGet]
            [Route("obter-todos")]
            public ActionResult<IEnumerable<ProdutoSelecaoVm>> ObterTodos()
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState); // 400 bad request (solicitação invalida)    
                }

                try
                {
                    var result = _produtoAppService.ObterTodos();

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
                    return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
                }

            }

        }
}
