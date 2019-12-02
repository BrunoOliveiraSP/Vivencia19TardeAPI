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
    public class ModuloDisciplinaController : ControllerBase
    {
        Business.ModuloDisciplinaBusiness bs = new Business.ModuloDisciplinaBusiness();

        [HttpPost]
        public ActionResult Inserir(Models.TbModuloDisciplina tb)
        {
            try
            {
                bs.Inserir(tb);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel error = new ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            }
        }
        [HttpGet]
        public List<Models.TbModuloDisciplina> ListarTodos()
        {
           List<Models.TbModuloDisciplina> tb = bs.ListaTodos();
           return tb;
        }

        [HttpPut]
        public void Alterar(Models.TbModuloDisciplina tb)
        {
            bs.Alterar(tb);
        }

        [HttpDelete("{id}")]
        public ActionResult Deletar(int id)
        {
            try
            {
                bs.Deletar(id);
                return Ok();
            }
            catch (System.Exception ex)
            {
                ErrorModel error = new ErrorModel(500, ex.Message);
                return StatusCode(500, error);
            } 
        }
    }
}