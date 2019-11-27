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
        public void Inserir(Models.TbModulo modulo)
        {
            db.Inserir(modulo);
        }
         [HttpGet]
         public List<Models.TbModulo> ListarTodos()
         {
             List<Models.TbModulo> lista = db.ConsultarTodos();
             return lista;
         }
         [HttpPut]
        public void Alterar(Models.TbModulo modulo) 
        {
            db.Alterar(modulo);
        }
        [HttpDelete ("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);
        }
    }
}