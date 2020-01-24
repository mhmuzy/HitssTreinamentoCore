﻿using Microsoft.AspNetCore.Mvc;
using Projeto.Services.Contracts;
using Projeto.Services.Models.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using Projeto.Application.ApplicationServices.Contracts;
//using Projeto.Application;
//using Projeto.Application.ViewModel;

namespace Projeto.Presentation.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class ProdutoController : ApiControllerAttribute
    {
        //atributo
        private readonly IProdutoAplicationServices service;

        public ProdutoController(IProdutoAplicationServices service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Post(Cadastro cadastrar)
        {
            //if (!ModelState.IsValid)
            //    return BadRequest();

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
                return OK($"Produto atualizado com sucesso");
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
                return Ok(service.ConsultarPorId(id).ToString());
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

        private HttpResponseMessage Ok(Consultar consultar)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                service.Excluir(id);
                return Ok($"Produto excluído com sucesso.");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
