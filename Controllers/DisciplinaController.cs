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

    public class DisciplinaController : ControllerBase
    {
        Business.DisciplinaBusiness bu = new Business.DisciplinaBusiness();
        

        [HttpPost]
        public ActionResult Inserir(Models.TbDisciplina disc)
        {
            try
            {
              bu.Inserir(disc);
              return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
            
        }
        
         [HttpPut]
         public ActionResult AlterarDisciplina (Models.TbDisciplina disciplina)
         {
             try
            {
              bu.Alterar(disciplina);
              return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
         } 
         
        [HttpGet("ListarTodos")]
        
        
          public List<Models.TbDisciplina> ListarTodos()
          {
             return bu.ListarTodos();
          }

          [HttpDelete("{id}")]
          public void Deletar(int id)
          {
              bu.Deletar(id);
          }

          [HttpGet("ListarNomeSigla/{Nome}/{Sigla}")]
          public ActionResult<List<Models.TbDisciplina>> ListarNomeSigla(string Nome, string Sigla)
          {
               try
            {
             return bu.ListarNomeSigla(Nome, Sigla);
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
          }
        
    }

}