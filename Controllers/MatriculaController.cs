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
        Business.MatriculaBusiness Bus = new Business.MatriculaBusiness();

        [HttpPost]

        public void Inserir (Models.MatriculaRequest request)
        {
             Bus.Inserir(request);
        } 

        [HttpPut]

        public void Alterar (Models.MatriculaRequest request)
        {
            Bus.alterar(request);
        }

        [HttpDelete]
        public void Deletar (Models.MatriculaRequest request)
        {
            Bus.Deletar(request);
        }

        [HttpGet("{nome}")]
        public List<Models.MatriculaResponse> Listar(string nome)
        {
            return Bus.Lista(nome, string.Empty, string.Empty, string.Empty);
        }


        
    }
}