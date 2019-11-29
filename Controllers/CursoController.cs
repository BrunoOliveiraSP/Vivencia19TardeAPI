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
    
    public class CursoController: ControllerBase
    {
        Business.CursoBusiness db = new Business.CursoBusiness();
        
        [HttpPost]
        public void Inserir (Models.TbCurso curso)
        {
            db.Inserir(curso);
        }

       
        [HttpPut]
        public void Alterar(Models.TbCurso curso) 
        {
            db.Alterar(curso);

        }
        [HttpDelete ("{id}")]
        public void Remover(int id)
        {
            db.Remover(id);

        }

        [HttpGet]
        public List<Models.TbCurso> ListarTodos()
        {
           List<Models.TbCurso> cursos = db.ListarTodos();
           return cursos;
        }

        [HttpGet("NmCurso/{NmCurso}")]
        public List<Models.TbCurso> ConsultarPorNome(string NmCurso)
        {
            List<Models.TbCurso> cursos = db.ConsultarPorNome(NmCurso);
            return cursos;
        }

        [HttpGet("Sigla/{Sigla}")]
        public List<Models.TbCurso> ConsultarPorSigla(string Sigla)
        {
            List<Models.TbCurso> cursos = db.ConsultarPorSigla(Sigla);
            return cursos;
        }
    }
}