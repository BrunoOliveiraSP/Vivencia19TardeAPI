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
    public class InscricaoController : ControllerBase
    {
        Business.InscricaoBusiness InscricaoBusiness = new Business.InscricaoBusiness();
        
        [HttpPost]
        public void Inserir(Models.TbInscricao inscricao)
        {
            InscricaoBusiness.Inserir(inscricao);
        } 
        [HttpPut]
        public void Alterar(Models.TbInscricao inscricao)
        {
            InscricaoBusiness.Alterar(inscricao);
        }
        [HttpDelete("{id}")]
        public void Remover(int id)
        {
            InscricaoBusiness.Remover(id);
        }

        [HttpGet("ConsultarTodos")]
        public List<Models.TbInscricao> ConsultarTodos()
        {
            return InscricaoBusiness.ConsultarTodos();
        }

        [HttpGet("ConsultarPorNomeEAno/{nome}/{ano}")]
        public List<Models.TbInscricao> ConsultarPorNomeEAno(string nome, int ano)
        {
            return InscricaoBusiness.ConsultarPorNomeEAno(nome, ano);
        }
    }
}