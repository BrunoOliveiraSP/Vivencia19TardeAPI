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
    public class ModuloController
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
            catch (ExceSystem.Exception ex)
            {
                ErrorModel error = new ErrorModel(500, ex.Message);
                return StatusCode(500, error);
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
            catch (ExceSystem.Exception ex)
            {
                ErrorModel error = new ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }
        }
        [HttpDelete ("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}