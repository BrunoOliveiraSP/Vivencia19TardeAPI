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
    public class SalaController : ControllerBase
    {
        Business.SalaBusiness business = new Business.SalaBusiness();

        [HttpPost("Inserir")]       
        public ActionResult Inserir(Models.TbSala sala)
        {        
            business.Inserir(sala);            
            return Ok();
        }

        [HttpGet("ListarTudo")]      
        public List<Models.TbSala> ListarTudo()
        {
            List<Models.TbSala> sala = business.ListarTudo();
            return sala;

        }
        [HttpDelete("Remover/{id}")]
        public void Remover(int id)
        {
            business.Remover(id);
        }
        [HttpPut("Alterar")]
        public void Alterar(Models.TbSala sala)
        {
            business.Alterar(sala);
        }
       
       [HttpGet("ListarNome/{instituicao}")]
        public List<Models.TbSala> ConsultarPorInstituicao(string instituicao)
        {
            List<Models.TbSala> consultar = business.ConsultarPorInstituicao(instituicao);
            return consultar;

        }       
                
    }
}