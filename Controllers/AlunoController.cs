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
         Business.AlunoBusiness Bus = new Business.AlunoBusiness();
        
        [HttpPost]
        public void Inserir(Models.TbAluno aluno)
        {
           
            Bus.inserir(aluno);
        }

         [HttpGet]
         public List<Models.TbAluno> ListarTodos()
         {
             List<Models.TbAluno> lista= Bus.ListarTodos();
             return lista;
         }
      
    }
}