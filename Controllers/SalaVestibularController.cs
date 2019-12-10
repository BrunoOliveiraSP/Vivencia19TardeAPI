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
        public void Inserir(Models.TbSalaVestibular request)
        {
               business.Inserir(request);              
        }

        [HttpDelete("Remover/{id}")]
        public void Remover(int id)
        {
            
                business.Remover(id);                   
        }

        [HttpPut]
        public void ALterar(Models.TbSalaVestibular salaaa)
        { 
            
                business.Alterar(salaaa);            
        }

        [HttpGet]
        public ActionResult<List<Models.SalaVestibularResponse>> ListarTudo()
        {
            try
            {
                List<Models.SalaVestibularResponse> consulta = business.ListarTudo();
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