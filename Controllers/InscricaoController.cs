using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InscricaoController : ControllerBase
    {
        Business.InscricaoBusiness InscricaoBusiness = new Business.InscricaoBusiness();
        
        [HttpPost]
        public ActionResult Inserir(Models.TbInscricao inscricao)
        {
            try
            {
                InscricaoBusiness.Inserir(inscricao);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        } 
        [HttpPut]
        public ActionResult Alterar(Models.TbInscricao inscricao)
        {
            try
            {
                InscricaoBusiness.Alterar(inscricao);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }
        [HttpDelete("{id}")]
        public ActionResult Remover(int id)
        {
            try
            {
                InscricaoBusiness.Remover(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet("ConsultarTodos")]
        public ActionResult<List<Models.TbInscricao>> ConsultarTodos()
        {
            try
            {
                return InscricaoBusiness.ConsultarTodos();
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet("ConsultarPorNomeEAno/{nome}/{ano}")]
        public ActionResult<List<Models.TbInscricao>> ConsultarPorNomeEAno(string nome, int ano)
        {
            try
            {
                return InscricaoBusiness.ConsultarPorNomeEAno(nome, ano);
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet("ConsultarAnoLetivo/{id}")]
        public ActionResult<Models.TbAnoLetivo> ConsultarAnoLetivo(int id)
        {
            try
            {
                return InscricaoBusiness.ConsultarAnoLetivo(id);
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet("ConsultarCurso/{id}")]
        public ActionResult<Models.TbCurso> ConsultarCurso(int id)
        {
            try
            {
                return InscricaoBusiness.ConsultarCurso(id);
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }
    }
}