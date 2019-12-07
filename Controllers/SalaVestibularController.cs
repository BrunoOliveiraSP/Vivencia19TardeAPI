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
  
    public class SalaVestibularController : ControllerBase  
    {
        Business.SalaVestibularBusiness business = new Business.SalaVestibularBusiness();

        [HttpPost]
        public ActionResult Inserir(Models.TbSalaVestibular sala)
        {
            try
            {
                business.Inserir(sala);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel error = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }
        }

        [HttpDelete("Remover/{id}")]
        public ActionResult Remover(int id)
        {
            try
            {
                business.Remover(id);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel error = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }
            
        }

        [HttpPut]
        public ActionResult ALterar(Models.TbSalaVestibular sala)
        { 
            try
            {
                business.Alterar(sala);
                return Ok();
            }
            catch(System.Exception ex)
            {
                Models.ErrorModel error = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }
        }

        [HttpGet]
        public ActionResult<List<Models.TbSalaVestibular>> ListarTudo()
        {
            try
            {
                List<Models.TbSalaVestibular> consulta = business.ListarTudo();
                return consulta;
            }
            catch(System.Exception ex)
            {
                 Models.ErrorModel error = new Models.ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }           
        }
    }
}