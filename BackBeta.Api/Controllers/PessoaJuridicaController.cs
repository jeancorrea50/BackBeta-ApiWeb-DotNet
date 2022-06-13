using BackBeta.Domain.Entities;
using BackBeta.Domain.Interface.Services.PessoaJuridica;
using BackBeta.Domain.Repository;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace BackBeta.Api.Controllers
{
    //http:localhost/api/PessoaJuridica
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaJuridicasController : ControllerBase
    {
        private readonly IPessoaJuridicaService _PessoaJuridicaSevice;
        public PessoaJuridicasController(IPessoaJuridicaService PessoaJuridicaService)
        {
            _PessoaJuridicaSevice = PessoaJuridicaService;
        }
        //localhost:44348/api/PessoaJuridicas/
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
                return Ok(await _PessoaJuridicaSevice.ObterTodos());
            }

            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        //localhost:44348/api/PessoaJuridica/{1}
        [Authorize("Bearer")]
        [HttpGet]
        [Route("obter-por-id")]
        public async Task<ActionResult> ObterPorId(int id)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request (solicitação invalida) 
            }

            try
            {
                return Ok(await _PessoaJuridicaSevice.ObterPorId(id));
            }

            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }

        [Authorize("Bearer")]
        [HttpPost]
        [Route("criar")]
        public async Task<ActionResult> Criar([FromBody] PessoaJuridicaEntity PessoaJuridica)
        {
            try
            {
                var result = await _PessoaJuridicaSevice.Criar(PessoaJuridica);

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
        public async Task<ActionResult> Alterar([FromBody] PessoaJuridicaEntity PessoaJuridica)
        {
            try
            {
                var result = await _PessoaJuridicaSevice.Alterar(PessoaJuridica);

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

        [Authorize("Bearer")]
        [HttpDelete]
        [Route("excluir")]
        public async Task<ActionResult> Excluir(int id)
        {
            try
            {
                var result = await _PessoaJuridicaSevice.Excluir(id);

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


