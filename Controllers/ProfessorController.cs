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

        [HttpDelete("{idProfessor}/{idLogin}")]
        public void Remover(int idProfessor, int idLogin)
        {
            bs.Remover(idProfessor, idLogin);
        }

        [HttpGet]
        public List<Models.TbProfessor> ListarTodos()
        {
            List<Models.TbProfessor> professores = bs.ListarTodos();
            return professores;

        }
 
        [HttpGet("Nome/{nome}")]
        public List<Models.TbProfessor> ConsultarNome (string nome)
        {
            List<Models.TbProfessor> professor = bs.ConsultarPorNome(nome);
            return professor;
        }
    }
}