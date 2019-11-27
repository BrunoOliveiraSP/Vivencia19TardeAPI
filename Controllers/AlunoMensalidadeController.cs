using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Vivencia19TardeAPI.Models;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AlunoMensalidadeController
    {
      Business.TbAlunoMensalidadeBusiness Bus = new Business.TbAlunoMensalidadeBusiness();
        
        [HttpPost]
        public void Inserir(TbAlunoMensalidade mensalidade)
        {
            Bus.Inserir(mensalidade);
        }

         [HttpGet]
         public List<TbAlunoMensalidade> Consultar()
         {
             List<TbAlunoMensalidade> lista= Bus.Consultar();
             return lista;
         }
         [HttpDelete]
         public void Deletar(int id)
         {
             Bus.Deletar(id);
             
         }
         [HttpPut]
         public void Alterar(int id,TbAlunoMensalidade mensalidade)
         {
             Bus.Alterar(id, mensalidade);
         }
      
    }
}