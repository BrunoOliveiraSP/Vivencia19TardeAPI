
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

    public class TurmaController: ControllerBase
    {
        Business.TurmaAnoLetivo business = new Business.TurmaAnoLetivo();
        
        [HttpPost]
        public ActionResult Inserir(Models.TbTurma turma)
        {
            try
            {
            business.Inserir(turma);
            return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
        }


        [HttpPut]
        public ActionResult Alterar(Models.TbTurma turma)
        {
            try
            {
            business.Alterar(turma);
            return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }

        }

        [HttpDelete("{id}")]
        public ActionResult Remover(int id)
        {
            try
            {
            business.Remover(id);
            return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
        }

        [HttpGet]
        public ActionResult <List<Models.TurmaResponse>> ListarTodos()
        {
            try
            {
            List<Models.TurmaResponse> lista = business.ListarTodos();
            return lista;
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }

        }
 
    }
}