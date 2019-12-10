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
        public ActionResult<Models.TbInscricao> Inserir(Models.TbInscricao inscricao)
        {
            try
            {
                InscricaoBusiness.Inserir(inscricao);
                return inscricao;
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

        [HttpGet]
        public ActionResult<List<Models.InscricaoResponse>> ConsultarTodos()
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
        public ActionResult<List<Models.InscricaoResponse>> ConsultarPorNomeEAno(string nome, int ano)
        {
            try
            {
                var lista = InscricaoBusiness.ConsultarPorNomeEAno(nome, ano); 
                return lista;
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet("ConsultarAnoLetivoLista/{id}")]
        public ActionResult<List<Vivencia19TardeAPI.Models.InscricaoResponse>> ConsultarAnoLetivoLista(int id)
        {
            try
            {
                return InscricaoBusiness.ConsultarAnoLetivoLista(id);
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }
    }
}