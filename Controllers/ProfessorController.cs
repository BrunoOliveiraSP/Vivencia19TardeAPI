using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;




namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController : ControllerBase
    {
        Business.ProfessorBusiness business = new Business.ProfessorBusiness();
        
        
        [HttpPost]
        public ActionResult Inserir(Models.ProfessorRequest professor)
        {
            try
            {
                business.Inserir(professor);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpPut]
        public ActionResult Alterar(Models.ProfessorRequest professor)
        {
            try
            {
                business.Alterar(professor);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpDelete("{idProfessor}/{idLogin}")]
        public ActionResult Remover(int idProfessor, int idLogin)
        {
            try
            {
                business.Remover(idProfessor, idLogin);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpGet]
        public ActionResult<List<Models.ProfessorResponse>> ListarTodos()
        {
            try
            {
                List<Models.ProfessorResponse> professores = business.ListarTodos();
                return professores;
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel erro= new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }

        }
 
        [HttpGet("Nome/{nome}")]
        public ActionResult<List<Models.ProfessorResponse>> ConsultarNome (string nome)
        {
            try
            {
                List<Models.ProfessorResponse> professor = business.ConsultarPorNome(nome);
                return professor;
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }
    }
}