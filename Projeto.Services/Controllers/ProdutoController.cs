﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Projeto.Application.ApplicationServices.Contracts;
using Projeto.Application;
using Projeto.Application.ViewModel;

namespace Projeto.Presentation.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class ProdutoController : ApiController
    {
        //atributo
        private readonly IProdutoApplicationService service;

        public ProdutoController(IProdutoApplicationService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Post(Cadastrar cadastrar)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                service.Inserir(cadastrar);
                return Ok($"Produto Cadastrado com Sucesso!");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
            
        }

        [HttpPut]
        public IActionResult Put(Editar editar)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                service.Atualizar(editar);
                return OK("Produto atualizado com sucesso");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(service.ObterTodos());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("{id}")]
        public HttpResponseMessage ConsultarPorId(int id)
        {
            try
            {
                return Ok(service.ObterporId(id));
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
                return Ok("Produto excluído com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
