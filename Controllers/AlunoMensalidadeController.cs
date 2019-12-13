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
    public class AlunoMensalidadeController:ControllerBase
    {
        Business.AlunoMensalidadeBusiness bus = new Business.AlunoMensalidadeBusiness();
        
        [HttpPost]
        public void Inserir(TbAlunoMensalidade mensalidade)
        {
            bus.Inserir(mensalidade);
        }

        [HttpGet]

        public List<Models.TbAlunoMensalidade> ListarTodos()
        {
            List<Models.TbAlunoMensalidade> lista = bus.ListarTodos();
            return lista;
        }

        [HttpPut]
        public void alterar (TbAlunoMensalidade mensalidade)
        {
            bus.alterar(mensalidade);
        } 
         
         
         [HttpDelete]
         public void Deletar(int id)
         {
             bus.Deletar(id);
             
         }

      
        
    }
}