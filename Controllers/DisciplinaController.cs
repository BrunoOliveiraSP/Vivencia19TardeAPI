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

    public class DisciplinaController
    {
        Business.DisciplinaBusiness bu = new Business.DisciplinaBusiness();

        [HttpPost]
        public void Inserir(Models.TbDisciplina disc)
        {
            bu.Inserir(disc);
        }


         [HttpPut]

         public void AlterarDisciplina (Models.TbDisciplina disciplina)
         {
             bu.Alterar(disciplina);
         } 
         
        [HttpGet("ListarTodos")]
        
        
          public List<Models.TbDisciplina> ListarTodos()
          {
             return bu.ListarTodos();
        
          }



          [HttpDelete("{id}")]
        
          public void Deletar(int id)
          {
              bu.Deletar(id);
          }



          [HttpGet("ListarNomeSigla/{Nome}/{Sigla}")]
        
          public List<Models.TbDisciplina> ListarNomeSigla(string Nome, string Sigla)
          {
             return bu.ListarNomeSigla(Nome, Sigla);
          }
        
    }

}