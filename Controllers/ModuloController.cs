using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vivencia19TardeAPI.Models;


namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ModuloController : ControllerBase
    {
       Business.ModuloBusiness db = new Business.ModuloBusiness();
      
        [HttpPost]
        public ActionResult Inserir(Models.TbModulo modulo)
        {
            try
            {
                db.Inserir(modulo);
                
                return Ok();
            }
            catch (System.Exception ex)
            {
                 ErrorModel erro = new ErrorModel(500, ex.Message);
                 return StatusCode(500, erro);
            }
        }


        [HttpGet]
         public List<Models.TbModulo> ListarTodos()
         {
             List<Models.TbModulo> lista = db.ConsultarTodos();
             return lista;
         }
         [HttpPut]
        public ActionResult Alterar(Models.TbModulo modulo) 
        {
            try
            {
                db.Alterar(modulo);
                return Ok();
            }
            catch (System.Exception ex)
            {
               ErrorModel erro = new ErrorModel(500, ex.Message);
                return StatusCode(500, erro);
            }
        }

        [HttpDelete ("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}