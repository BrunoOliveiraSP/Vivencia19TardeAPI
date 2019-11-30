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
        Business.AlunoMensalidadeBusiness Bus = new Business.AlunoMensalidadeBusiness();
        
        [HttpPost]
        public void Inserir(TbAlunoMensalidade mensalidade)
        {
            Bus.Inserir(mensalidade);
        }

        [HttpGet]

        public List<Models.TbAlunoMensalidade> ListarTodos()
        {
            List<Models.TbAlunoMensalidade> lista = Bus.ListarTodos();
            return lista;
        }

        [HttpPut]
        public void alterar (TbAlunoMensalidade mensalidade)
        {
            Bus.alterar(mensalidade);
        } 
         
         
         [HttpDelete]
         public void Deletar(int id)
         {
             Bus.Deletar(id);
             
         }

      
        
    }
}