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
    public class AlunoController
    {
         Business.AlunoBusiness bus = new Business.AlunoBusiness();
        
        [HttpPost]
        public void Inserir(Models.TbAluno aluno)
        {
           
            bus.inserir(aluno);
        }

         [HttpGet]
         public List<Models.TbAluno> ListarTodos()
         {
             List<Models.TbAluno> lista= bus.ListarTodos();
             return lista;
         }
         [HttpDelete]
         public void Deletar(Models.TbAluno aluno)
         {
             Models.TbAluno consulta = bus.consular(aluno);
             bus.Deletar(consulta.IdAluno); 
         }
         [HttpPut]
         public void Alterar(Models.TbAluno aluno)
         {
             bus.Alterar(aluno);
         }
      
    }
}