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
    public class FornecedorController 
        : ApiControllerAttribute
    {
        //atributo
        private readonly IFornecedorApplicationServices service;

        public static object ModelState { get; private set; }

        public FornecedorController(IFornecedorApplicationServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Post(Cadastro cadastrar)
        {
            //if (!FornecedorController.ModelState)
                return BadRequest();
            
        }

        private IActionResult BadRequest()
        {
            throw new NotImplementedException();
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
            return BadRequest();
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
                string consulta = service.consultars().ToString();
                return Ok(consulta);
            }
            catch (Exception e)
            {
                string message = e.Message;
                int codigo = 500;
                return StatusCode(codigo, $"{message}");
            }
        }

        [HttpGet("{id}")]
        public IActionResult ConsultarPorId(int id)
        {
            try
            {
                string consulta = service.GetConsultarId(id).ToString();
                return Ok(consulta);
            }
            catch (Exception e)
            {
                string message = e.Message;
                int codigo = 500;
                return StatusCode(codigo, $"{message}");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                string message = "Fornecedor excluído com sucesso.";
                service.Excluir(id);
                return Ok($"{message}");
            }
            catch (Exception e)
            {
                string message = e.Message;
                int codigo = 500;
                return StatusCode(codigo, $"{message}");
            }
        }
    }
}
