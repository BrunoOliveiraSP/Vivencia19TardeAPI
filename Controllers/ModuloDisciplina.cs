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
    public class ModuloDisciplina : ControllerBase
    {
        Business.ModuloDisciplinaBusiness bs = new Business.ModuloDisciplinaBusiness();

        [HttpPost]
        public void Inserir(Models.TbModuloDisciplina tb)
        {
            bs.Inserir(tb);
        }
        
        [HttpGet]
        public List<Models.TbModuloDisciplina> ListarTodos()
        {
           List<Models.TbModuloDisciplina> tb = bs.ListaTodos();
           return tb;
        }
    }
}