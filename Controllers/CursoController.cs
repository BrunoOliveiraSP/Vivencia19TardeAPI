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
        
        [HttpPost]
        public void Inserir (Models.TbCurso curso)
        {
            db.Inserir(curso);
        }

       
        [HttpPut]
        public void Alterar(Models.TbCurso curso) 
        {
            db.Alterar(curso);

        }
        [HttpDelete ("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);

        }

    }
}