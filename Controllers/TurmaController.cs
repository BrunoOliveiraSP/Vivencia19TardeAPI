
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc;

namespace Vivencia19TardeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TurmaController: ControllerBase
    {
        Business.TurmaAnoLetivo business = new Business.TurmaAnoLetivo();
        
        [HttpPost]
        public void Inserir(Models.TbTurma turma)
        {
            business.Inserir(turma);
        }

        [HttpPut]
        public void Alterar(Models.TbTurma turma)
        {
            business.Alterar(turma);

        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            business.Remover(id);
        }

        [HttpGet]
        public List<Models.TbTurma> ListarTodos ()
        {
            List<Models.TbTurma> lista = business.ListarTodos();
            return lista;

        }
 
    }
}