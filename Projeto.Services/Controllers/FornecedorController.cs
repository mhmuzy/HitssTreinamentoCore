using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Contracts;
using Projeto.Services.Contracts.Services;
using Projeto.Services.Models.Fornecedor;

namespace Projeto.Presentation.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class FornecedorController : ApiControllerAttribute
    {
        //atributo
        private readonly IFornecedorApplicationServices service;

        public FornecedorController(IFornecedorApplicationServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Post(Cadastro cadastrar)
        {
           //if (!FornecedorController.ModelState.IsValid)
           //    return BadRequest();

            try
            {
                service.Inserir(cadastrar);
                return Ok($"Fornecedor Cadastrado com Sucesso!");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
            
        }

        private IActionResult StatusCode(int v, string message)
        {
            throw new NotImplementedException();
        }

        private IActionResult Ok(string v)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public IActionResult Put(Editar editar)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();

            try
            {
                service.Atualizar(editar);
                return OK($"Fornecedor atualizado com sucesso");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        private IActionResult OK(string v)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(service.consultars().ToString());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult ConsultarPorId(int id)
        {
            try
            {
                return Ok(service.GetConsultarId(id).ToString());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Excluir(id);
                return Ok("Fornecedor excluído com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
