using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class CursoController: ControllerBase
    {
        Business.CursoBusiness db = new Business.CursoBusiness();
        Business.DisciplinaBusiness bu = new Business.DisciplinaBusiness();
        
        [HttpPost]
        public ActionResult<int> Inserir (Models.TbCurso curso)
        {
            try
            {
                 db.Inserir(curso);
                 
                 int id = curso.IdCurso;
                 return id;
                
                
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            }
        }

       
        [HttpPut]
        public ActionResult Alterar(Models.TbCurso curso) 
        {
             try
            {
                 db.Alterar(curso);
                 return Ok();
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            } 
            

        }
        
        
        [HttpDelete ("{id}")]
        public ActionResult Remover(int id)
        {
            try
            {
                  db.Remover(id);
                 return Ok();
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            }  
        }

        [HttpGet]
        public ActionResult<List<Models.TbCurso>> ListarTodos()
        {      
            try
            {
                 List<Models.TbCurso> cursos = db.ListarTodos();
                 return cursos;
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            }      
        }

        
        [HttpGet("NmCurso/{NmCurso}")]
        public ActionResult<List<Models.TbCurso>> ConsultarPorNome(string NmCurso)
        {
            try
            {
                 List<Models.TbCurso> cursos = db.ConsultarPorNome(NmCurso);
                 return cursos;
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            }  
            
        }

        [HttpGet("Sigla/{Sigla}")]
        public ActionResult<List<Models.TbCurso>> ConsultarPorSigla(string Sigla)
        {
            try
            {
                 List<Models.TbCurso> cursos = db.ConsultarPorSigla(Sigla);
                 return cursos;
            }               
            catch(System.Exception ex)
            {
                Models.ErrorModel erro = new Models.ErrorModel(500, ex.Message);
                return StatusCode (500, erro);
            } 
            
        }
    }
}