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
    public class AlunoLocalizacaoController:ControllerBase
    {
        Business.AlunoLocalizacaoBusiness bus = new Business.AlunoLocalizacaoBusiness();
        
        [HttpPost]
        public void Inserir(Models.TbAlunoLocalizacao localizacao)
        {
            bus.Inserir(localizacao);
        }

         [HttpGet]
         public List<Models.TbAlunoLocalizacao> Consultar()
         {
             List<Models.TbAlunoLocalizacao> lista = bus.Consultar();
             return lista;
         }

         [HttpDelete]
         public void Deletar(int id)
         {
             bus.Deletar(id);
             
         }

         [HttpPut]
         public void Alterar(int id,Models.TbAlunoLocalizacao localizacao)
         {
             bus.Alterar(localizacao);
         }
    }
}
    
