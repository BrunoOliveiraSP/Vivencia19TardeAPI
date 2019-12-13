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
    public class MatriculaController
    {
        Business.MatriculaBusiness bus = new Business.MatriculaBusiness();

        [HttpPost]

        public void Inserir (Models.MatriculaRequest request)
        {
             bus.Inserir(request);
        } 

        [HttpPut]

        public void Alterar (Models.MatriculaRequest request)
        {
            bus.alterar(request);
        }

        [HttpDelete("{id}")]
        public void Deletar (int id)
        {
            bus.Deletar(id);
        }


        [HttpGet("{nome}/{ra}/{curso}/{turma}/{idanoletivo}")]
        public List<Models.MatriculaResponse> Listar(string nome, string ra, string curso, string turma, int idanoletivo)
        {
            return bus.Lista(nome, ra, curso, turma, idanoletivo);
        }
        
        [HttpGet("ListarTodos")]
        public List<Models.MatriculaResponse> ListarTodos()
        {
            return bus.ListarTodos();

        }

        
    }
}