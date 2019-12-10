
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;
using Vivencia19TardeAPI.Models;


namespace Vivencia19TardeAPI_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnoLetivoController : ControllerBase
    {
        Vivencia19TardeAPI.Business.AnoLetivoBusiness db = new  Vivencia19TardeAPI.Business.AnoLetivoBusiness();

       [HttpPost]
        public ActionResult Inserir(Vivencia19TardeAPI.Models.TbAnoLetivo ano)
        {
            try
            {

            db.Inserir(ano);
            return Ok();

            }
            catch(System.Exception ex)
            {
             ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
        }

        [HttpPut]
        public ActionResult Alterar(Vivencia19TardeAPI.Models.TbAnoLetivo ano)
        {
            try
            {
            db.Alterar(ano);
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
            db.Remover(id);
            return Ok();
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }
            
        }

        [HttpGet]
        public ActionResult <List<Vivencia19TardeAPI.Models.TbAnoLetivo>> ListarTodos ()
        {
            try
            {
            List<Vivencia19TardeAPI.Models.TbAnoLetivo> ano = db.ListarTodos();
            return ano;
            }
            catch(System.Exception ex)
            {
              ErrorModel error = new ErrorModel(500, ex.Message);
              return StatusCode(500, error);
            }

        }
 
        [HttpGet("ConsultarAnoLetivo/{id}")]
        public ActionResult<Vivencia19TardeAPI.Models.TbAnoLetivo> ConsultarAnoLetivo(int id)
        {
            try
            {
                return db.ConsultarAnoLetivo(id);
            }
            catch (System.Exception ex)
            {
                ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }
    }
}