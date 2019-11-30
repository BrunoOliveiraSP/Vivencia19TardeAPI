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
    public class ProfessorController : ControllerBase
    {
        Business.ProfessorBusiness bs = new Business.ProfessorBusiness();
        [HttpPost]
        public void Inserir(Models.ProfessorRequest professor)
        {
            bs.Inserir(professor);
        }

        [HttpPut]
        public void Alterar(Models.ProfessorRequest professor)
        {
            bs.Alterar(professor);

        }

        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            bs.Remover(id);
        }

        [HttpGet]
        public List<Models.TbProfessor> ListarTodos ()
        {
            List<Models.TbProfessor> professor = bs.ListarTodos();
            return professor;

        }
 
        [HttpGet("Nome/{nome}")]
        public List<Models.TbProfessor> ConsultarNome (string nome)
        {
            List<Models.TbProfessor> professor = bs.ConsultarPorNome(nome);
            return professor;
        }


    }
}