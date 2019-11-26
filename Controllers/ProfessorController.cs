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

        [HttpPost]
        public void Inserir(Models.TbProfessor professor)
        {

        }

        [HttpPut]
        public void Alterar(Models.TbProfessor professor)
        {

        }

        [HttpDelete]
        public void Remover(int id)
        {

        }

        //[HttpGet]
        //public List<Models.TbProfessor> ListarTodos ()
        //{

        //}
 
        //[HttpGet]
        //public List<Models.TbProfessor> ConsultarNome (string nome)
        //{
            
        //}


    }
}